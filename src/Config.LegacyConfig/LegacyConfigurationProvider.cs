using Microsoft.Extensions.Configuration;

namespace HA.Extensions.Configuration.Legacy
{
    using System.Configuration;

    public class LegacyConfigurationProvider : ConfigurationProvider, IConfigurationSource
    {
        private readonly Configuration _legacyConfiguration;

        public LegacyConfigurationProvider(
            string path
            )
        {
            var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = path };
            _legacyConfiguration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
        }

        public override void Load()
        {
            foreach (ConnectionStringSettings connectionString in _legacyConfiguration.ConnectionStrings.ConnectionStrings)
            {
                Data.Add(
                    $"ConnectionStrings:{connectionString.Name}",
                    connectionString.ConnectionString
                    );
            }

            foreach (var settingKey in _legacyConfiguration.AppSettings.Settings.AllKeys)
            {
                Data.Add(
                    $"AppSettings:{settingKey}",
                    _legacyConfiguration.AppSettings.Settings[settingKey].Value
                    );
            }
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return this;
        }
    }
}
