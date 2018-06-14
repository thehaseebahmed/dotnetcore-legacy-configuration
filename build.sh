dotnet restore
dotnet pack src/Config.LegacyConfig/Config.LegacyConfig.csproj
dotnet nuget push src/Config.LegacyConfig/bin/**/*.nupkg -s https://api.nuget.org/v3/index.json -k keygoeshere