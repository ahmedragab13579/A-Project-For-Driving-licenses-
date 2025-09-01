using Microsoft.Extensions.Configuration;
using System.Configuration;

using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DVDL_InfrastructureLayer
{
    public class ConfigManager
    {
        private readonly IConfiguration _config;

        public ConfigManager()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) 
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public string GetAppSetting(string key)
        {
            return _config["AppSettings:" + key];
        }

        public string GetConnectionString(string name)
        {
            return _config.GetConnectionString(name);
        }
    }
}
