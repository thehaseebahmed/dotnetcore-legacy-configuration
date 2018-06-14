dotnet restore
dotnet pack src/Config.LegacyConfig/Config.LegacyConfig.csproj

if [ "${TRAVIS_PULL_REQUEST}" = "false" ] && [	"${TRAVIS_BRANCH}" == "${MY_DEFAULT_BRANCH}" ]; then
  dotnet nuget push src/Config.LegacyConfig/bin/**/*.nupkg -s https://api.nuget.org/v3/index.json -k keygoeshere
fi