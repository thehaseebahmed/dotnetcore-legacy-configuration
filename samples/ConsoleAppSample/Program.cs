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
                .AddLegacyConfig("App.Config")
                .AddLegacyConfig("My.Config")
                .Build();

            foreach (var keyValuePair in configuration.AsEnumerable())
            {
                Console.WriteLine($"{keyValuePair.Key} = {keyValuePair.Value}");
            }
        }
    }
}
