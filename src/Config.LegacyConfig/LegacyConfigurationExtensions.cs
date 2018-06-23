using System;
using Microsoft.Extensions.Configuration;

namespace HA.Extensions.Configuration.Legacy
{
    public static class LegacyConfigurationExtensions
    {
        public static IConfigurationBuilder AddLegacyConfig(
            this IConfigurationBuilder builder,
            string path
            )
        {
            if (builder == null) { throw new ArgumentNullException(nameof(builder)); }
            if (string.IsNullOrEmpty(path)) { throw new ArgumentNullException(nameof(path)); }

            return Add(builder, path);
        }

        private static IConfigurationBuilder Add(
            IConfigurationBuilder builder,
            string path
            )
        {
            return builder.Add(new LegacyConfigurationProvider(path));
        }
    }
}
