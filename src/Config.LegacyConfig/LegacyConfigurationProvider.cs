using Microsoft.Extensions.Configuration;

namespace HA.Extensions.Configuration.Legacy
{
    using System.Configuration;

    public class LegacyConfigurationProvider : ConfigurationProvider, IConfigurationSource
    {
        public override void Load()
        {
            foreach (ConnectionStringSettings connectionString in ConfigurationManager.ConnectionStrings)
            {
                Data.Add($"ConnectionStrings:{connectionString.Name}", connectionString.ConnectionString);
            }

            foreach (var settingKey in ConfigurationManager.AppSettings.AllKeys)
            {
                Data.Add(settingKey, ConfigurationManager.AppSettings[settingKey]);
            }
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return this;
        }
    }
}
