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

FileUtils.mkdir_p(opts[:buildroot])

Dir.chdir(opts[:buildroot]) do
  system2("cmake", *argv, *%w(--trace --trace-format=json-v1 --trace-expand --trace-redirect=CMakeTrace.log -Wno-dev), opts[:sourceroot], exception: true)
  # replay trace to get (part of) CMake variables
  cmake_variables = {}
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
        raise 'unknown CMAKE_SYSTEM_NAME, specify --rid'
      end
      rid_platform = case cmake_variables["CMAKE_SYSTEM_PROCESSOR"]
      when /i[3-6]86/, 'x86' then 'x86'
      when 'amd64', 'x86_64', 'x64' then 'x64'
      when 'aarch64', 'arm64' then 'arm64'
      when 'armv7', 'arm' then 'arm'
      else
        raise 'unknown CMAKE_SYSTEM_PROCESSOR, specify --rid'
      end
      opts[:rid] = "#{rid_system}-#{rid_platform}"
    end
  end
  puts "building packages for RID #{opts[:rid]}"
  system2(*%w(cmake --build . --target tdjson), exception: true)
  dll_suffix = cmake_variables["CMAKE_SHARED_LIBRARY_SUFFIX"]
  pattern = File.join(Dir.pwd, '*'+dll_suffix)
  if File.const_defined?(:ALT_SEPARATOR) && File.const_get(:ALT_SEPARATOR) == '\\'
    pattern.gsub!(File::SEPARATOR, '\\')
  end
  system2('dotnet', 'pack', File.join(scriptroot, 'native-pkg', 'stub', 'TDLib.JsonClient.Native.csproj'),
          '-c', 'Release', "-p:UseReleaseVersioning=#{opts[:release]}", '--no-restore', '--no-build',
          '-nologo', '-o', opts[:outdir], exception: true)
  system2('dotnet', 'pack', File.join(scriptroot, 'native-pkg', 'runtime', 'runtime.RID.TDLib.JsonClient.Native.csproj'),
         '-c', 'Release', "-p:RID=#{opts[:rid]}", "-p:IncludePattern=#{pattern}", "-p:UseReleaseVersioning=#{opts[:release]}",
         '--no-restore', '--no-build', '-nologo', '-o', opts[:outdir], exception: true)
end
