#!/usr/bin/env ruby
require 'optparse'
require 'fileutils'
require 'json'
require 'pp'

scriptroot = File.realdirpath(File.dirname($0))
opts = {
  buildroot: File.join(scriptroot, 'build'),
  outdir: File.join(scriptroot, 'pkgs'),
  release: false
}
argv = ARGV.map(&:itself)
OptionParser.new do |parser|
  parser.banner = "usage: #$0 [options] -- [tdlib CMake options]"
  parser.on("-bDIR", "--build-root=DIR", "set build root to DIR, defaults to #{opts[:buildroot]}") do |dir|
    opts[:buildroot] = dir
  end

  parser.on("-oDIR", "--output=DIR", "set output directory to DIR, defaults to #{opts[:outdir]}") do |dir|
    opts[:outdir] = dir
  end

  parser.on("-r", "--use-release-versioning", "remove commit hash from package version") do |release|
    opts[:release] = release
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
FileUtils.mkdir_p(opts[:outdir])

Dir.chdir(opts[:buildroot]) do
  system2('dotnet', 'pack', File.join(scriptroot, 'tdlib.sln'), '-c', 'Release', '-p:Platform=Any CPU',
          "-p:UseReleaseVersioning=#{opts[:release]}", '-nologo', '-o', opts[:outdir], exception: true)
  system2('dotnet', 'pack', File.join(scriptroot, 'native-pkg', 'stub', 'TDLibCore.JsonClient.Native.csproj'),
          '-c', 'Release', "-p:UseReleaseVersioning=#{opts[:release]}", '-nologo', '-o', opts[:outdir], exception: true)
  system2('dotnet', 'pack', File.join(scriptroot, 'native-pkg', 'stub', 'TDLibCore.JsonClient.Native.csproj'),
          '-c', 'Release', "-p:UseReleaseVersioning=#{opts[:release]}", '-p:PackageId=TDLibCore.NativeClient.Native',
          '-nologo', '-o', opts[:outdir], exception: true)
end
