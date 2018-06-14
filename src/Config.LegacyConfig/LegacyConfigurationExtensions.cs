using System;
using Microsoft.Extensions.Configuration;

namespace HA.Extensions.Configuration.Legacy
{
    public static class LegacyConfigurationExtensions
    {
        public static IConfigurationBuilder AddLegacyConfig(
            this IConfigurationBuilder builder
            )
        {
            if (builder == null) { throw new ArgumentNullException(nameof(builder)); }

            return builder.Add(new LegacyConfigurationProvider());
        }
    }
}
