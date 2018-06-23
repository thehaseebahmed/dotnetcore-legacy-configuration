<!-- BASE TEMPLATE FROM: https://github.com/dbader/readme-template/blob/master/README.md -->

# Legacy Configuration

[![Build Status](https://travis-ci.com/haseebahmed7/dotnetcore-legacy-configuration.svg?branch=master)](https://travis-ci.com/haseebahmed7/dotnetcore-legacy-configuration)

> Legacy configuration (app.config, web.config) provider implementation for Microsoft.Extensions.Configuration.

## Usage example

### App.config
```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <connectionStrings>
<add name="AzureSqlDatabase" connectionString="[CONNECTION_STRING_HERE]" providerName="System.Data.SqlClient" />
  </connectionStrings>
  <appSettings>
    <add key="SampleAppSettingOne" value="Hello" />
    <add key="SampleAppSettingTwo" value="World" />
  </appSettings>
</configuration>
```

### Some.cs file
```csharp
IConfiguration configuration = new ConfigurationBuilder()
    .AddLegacyConfig("App.Config")
    .Build();

Console.WriteLine($"App Settings: {configuration["SampleAppSettingOne"]}, {configuration["SampleAppSettingTwo"]}");
```

## Development setup

Make sure you have the following setup on your development machine:
- .NET Core 2.0.x
- .NET Framework 7.0
- Visual Studio 2017 or VS Code

Simply open the solution and build to get started.

## Release History

* 0.0.1
    * Initial release.

## Meta

Haseeb Ahmed – [@haseebahmed7](https://twitter.com/haseebahmed7) – hello@haseeb-ahmed.com

Distributed under the MIT license. See ``LICENSE`` for more information.

<https://github.com/haseebahmed7/dotnetcore-legacy-configuration>

## Contributing

1. Fork it (<https://github.com/haseebahmed7/dotnetcore-legacy-configuration>)
2. Create your feature branch (`git checkout -b yourname/feature/fooBar`)
3. Commit your changes (`git commit -am 'Add some fooBar'`)
4. Push to the branch (`git push origin feature/fooBar`)
5. Create a new Pull Request.

## Special Thanks

- Ben Foster, this project is based on his [article](http://benfoster.io/blog/net-core-configuration-legacy-projects).