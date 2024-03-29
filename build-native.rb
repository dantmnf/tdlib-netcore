#!/usr/bin/env ruby
require 'optparse'
require 'fileutils'
require 'json'
require 'pp'

scriptroot = File.realdirpath(File.dirname($0))
opts = {
  buildroot: File.join(scriptroot, 'build'),
  sourceroot: File.join(scriptroot, 'td'),
  outdir: File.join(scriptroot, 'pkgs'),
  tdbridge: false,
  tdjson: true,
  release: false
}
argv = ARGV.map(&:itself)
OptionParser.new do |parser|
  parser.banner = "usage: #$0 [options] -- [tdlib CMake options]"
  parser.on("-bDIR", "--build-root=DIR", "set build root to DIR, defaults to #{opts[:buildroot]}") do |dir|
    opts[:buildroot] = dir
  end

  parser.on("-sDIR", "--source-root=DIR", "set tdlib source root to DIR, defaults to #{opts[:sourceroot]}") do |dir|
    opts[:sourceroot] = dir
  end

  parser.on("-oDIR", "--output=DIR", "set output directory to DIR, defaults to #{opts[:outdir]}") do |dir|
    opts[:outdir] = dir
  end

  parser.on("--[no-]build-tdjson", "build tdjson and runtime.RID.TDLibCore.JsonClient.Native") do |build|
    opts[:tdjson] = build
  end

  parser.on("--build-tdbridge", "build tdbridge and runtime.RID.TDLibCore.NativeClient.Native") do |build|
    opts[:tdbridge] = build
  end

  parser.on("-r", "--use-release-versioning", "remove commit hash from package version") do |release|
    opts[:release] = release
  end

  parser.on("--rid=RID", "override RID detection") do |rid|
    opts[:rid] = rid
  end

  parser.on_tail("-h", "--help", "Show this message") do
    puts parser
    exit
  end
end.parse!(argv)

def system2(*args, exception: false)
  puts "running " + args.inspect
  system(*args, exception: exception)
end

FileUtils.mkdir_p(File.join(opts[:buildroot], 'tdjson'))
FileUtils.mkdir_p(File.join(opts[:buildroot], 'tdbridge'))

Dir.chdir(opts[:buildroot]) do
  dll_suffix = nil
  tdjson_built = false
  cmake_variables = {}
  # replay trace to get (part of) CMake variables
  replay_cmake_trace = lambda do
    trace = IO.readlines('CMakeTrace.log')
    trace.map!{|x| JSON.parse(x)}
    trace.each do |x|
      if x["cmd"]&.downcase == 'set'
        name = x.dig("args", 0)
        value = x["args"][1..-1]
        if value.length >= 2 && value[-1] == 'PARENT_SCOPE'
          value.pop
        elsif value.length >= 4 && value[1..-1].include?('CACHE')
          value[value.index('CACHE')..-1] = []
        end
        value = value[0] if value.length == 1
        cmake_variables[name] = value
      end
    end
    unless opts[:rid]
      if cmake_variables["MSVC"]
        msvcarch = cmake_variables["MSVC_CXX_ARCHITECTURE_ID"]
        opts[:rid] = "win-#{msvcarch.downcase}"
      else
        rid_system = case cmake_variables["CMAKE_SYSTEM_NAME"]
        when 'Windows' then 'win'
        when 'Linux' then 'linux'
        when 'Darwin' then 'osx'
        else
          raise "unknown CMAKE_SYSTEM_NAME #{cmake_variables["CMAKE_SYSTEM_NAME"]}, specify --rid"
        end
        rid_platform = case cmake_variables["CMAKE_SYSTEM_PROCESSOR"].downcase
        when /i[3-6]86/i, 'x86' then 'x86'
        when 'amd64', 'x86_64', 'x64' then 'x64'
        when 'aarch64', 'arm64' then 'arm64'
        when 'armv7', 'arm' then 'arm'
        else
          raise "unknown CMAKE_SYSTEM_PROCESSOR #{cmake_variables["CMAKE_SYSTEM_PROCESSOR"]}, specify --rid"
        end
        opts[:rid] = "#{rid_system}-#{rid_platform}"
      end
    end
    puts "building packages for RID #{opts[:rid]}"
  end

  get_pattern = lambda do
    pattern = File.join(Dir.pwd, '*'+cmake_variables["CMAKE_SHARED_LIBRARY_SUFFIX"])
    if File.const_defined?(:ALT_SEPARATOR) && File.const_get(:ALT_SEPARATOR) == '\\'
      pattern.gsub!(File::SEPARATOR, '\\')
    end
    pattern
  end

  if opts[:tdbridge]
    Dir.chdir('tdbridge') do
      system2("cmake", *argv, *%w(--trace --trace-format=json-v1 --trace-expand --trace-redirect=CMakeTrace.log -Wno-dev), "-DUSE_TD_SOURCE_TREE:PATH=#{opts[:sourceroot]}", "-DTD_BUILD_BINARY_DIR:PATH=../tdjson", File.join(scriptroot, 'TDLibCore.NativeClient.Bridge'), exception: true)
      replay_cmake_trace.call
      system2('cmake', '--build', '.', '--target', 'TDLibCore.NativeClient.Native', exception: true)
      pattern = get_pattern.call
      system2('dotnet', 'pack', File.join(scriptroot, 'native-pkg', 'runtime', 'runtime.RID.TDLibCore.JsonClient.Native.csproj'),
      '-c', 'Release', "-p:RID=#{opts[:rid]}", "-p:IncludePattern=#{pattern}", "-p:UseReleaseVersioning=#{opts[:release]}",
      '-p:BasePackageId=TDLibCore.NativeClient.Native', '-nologo', '-o', opts[:outdir], exception: true)
      if opts[:tdjson]
        system2('cmake', '--build', '.', '--target', 'tdjson', exception: true)
        tdjson_built = true
      end
    end
  end
  if opts[:tdjson]
    Dir.chdir('tdjson') do
      unless tdjson_built
        system2("cmake", *argv, *%w(--trace --trace-format=json-v1 --trace-expand --trace-redirect=CMakeTrace.log -Wno-dev), opts[:sourceroot], exception: true)
        replay_cmake_trace.call
        system2('cmake', '--build', '.', '--target', 'tdjson', exception: true)
      end
      pattern = get_pattern.call
      system2('dotnet', 'pack', File.join(scriptroot, 'native-pkg', 'runtime', 'runtime.RID.TDLibCore.JsonClient.Native.csproj'),
      '-c', 'Release', "-p:RID=#{opts[:rid]}", "-p:IncludePattern=#{pattern}", "-p:UseReleaseVersioning=#{opts[:release]}",
      '-nologo', '-o', opts[:outdir], exception: true)
    end
  end

end
