version_match = IO.read(File.join(ARGV[0], 'CMakeLists.txt')).match(/TDLib\s+VERSION\s+(\S+)/)
td_api_commit = Dir.chdir(ARGV[0]) { `git rev-list -1 HEAD td/generate/scheme/td_api.tl`.strip }
td_commit = Dir.chdir(ARGV[0]) { `git rev-list -1 HEAD`.strip }

IO.write(ARGV[1], <<"END")
<!-- auto-generated file -->
<Project>
    <PropertyGroup>
        <Version>#{version_match[1].encode(xml: :text)}</Version>
        <TdApiCommitHash>#{td_api_commit.encode(xml: :text)}</TdApiCommitHash>
        <TdCommitHash>#{td_commit.encode(xml: :text)}</TdCommitHash>
    </PropertyGroup>
</Project>
END
