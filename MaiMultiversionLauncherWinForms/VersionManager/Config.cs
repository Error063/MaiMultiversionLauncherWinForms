using System;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace VersionManager
{
    public class Config
    {
        private string _yamlFilePath;
        private ConfigStruct? _config;

        public Config(string configPath)
        {
            _yamlFilePath = configPath;
            Load();
        }

        public class ConfigStruct
        {
            public class Settings
            {
                public string GamePath = "";
                public string UnityPlayerCommandArgs = "";
                public bool LoadOdd = false;
                public bool LoadMod = false;
                public bool LoadAmDaemon = true;
            }

            public Settings settings;
        }

        public ConfigStruct config
        {
            get => _config ?? throw new NullReferenceException("Config is not loaded");
            set
            {
                _config = value;
                Save(_config ?? throw new NullReferenceException("Null Config Given"));
            }
        }

        public void Load()
        {
            try
            {
                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .Build();
                var serializer = new SerializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .Build();
                if (!File.Exists(_yamlFilePath))
                {

                    _config = new()
                    {
                        settings = new()
                    };
                    File.WriteAllText(_yamlFilePath, serializer.Serialize(_config));
                }
                _config = deserializer.Deserialize<ConfigStruct>(File.ReadAllText(_yamlFilePath));
                File.WriteAllText(_yamlFilePath, serializer.Serialize(_config));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading configuration: {ex.Message}");
            }
        }

        public void Save(ConfigStruct config)
        {
            try
            {
                var serializer = new SerializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .Build();
                File.WriteAllText(_yamlFilePath, serializer.Serialize(config));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving configuration: {ex.Message}");
            }
        }
    }
}
