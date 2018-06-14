using System;
using HA.Extensions.Configuration.Legacy;
using Microsoft.Extensions.Configuration;

namespace ConsoleAppSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .AddLegacyConfig()
                .Build();

            Console.WriteLine($"App Settings: {configuration["SampleAppSettingOne"]}, {configuration["SampleAppSettingTwo"]}");
        }
    }
}
