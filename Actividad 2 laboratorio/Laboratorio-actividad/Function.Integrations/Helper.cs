using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Function.Integrations
{
    public static class Helper
    {
        private static Settings _settings;
        public static Settings Settings
        {
            get 
            {
                if (_settings != null)
                {
                    return _settings;
                }
                var config = new ConfigurationBuilder()
                    .AddJsonFile("local.settings.json")
                    .AddEnvironmentVariables()
                    .Build();
                _settings = new Settings();
                config.Bind(_settings);
                return _settings;
            }
        }

    }
}
