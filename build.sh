dotnet restore
dotnet pack src/Config.LegacyConfig/Config.LegacyConfig.csproj

echo "Is Pull Request?" $TRAVIS_PULL_REQUEST
echo "Publish Branch: " $MY_PUBLISH_BRANCH

if [ "${TRAVIS_PULL_REQUEST}" = "false" ] && [	"${TRAVIS_BRANCH}" == "${MY_PUBLISH_BRANCH}" ]; then
  dotnet nuget push src/Config.LegacyConfig/bin/**/*.nupkg -s https://api.nuget.org/v3/index.json -k keygoeshere
fi