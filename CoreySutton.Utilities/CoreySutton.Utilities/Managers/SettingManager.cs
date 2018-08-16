using System;
using System.Configuration;

namespace CoreySutton.Utilities
{
    public class SettingManager : ISettingManager
    {
        private readonly ApplicationSettingsBase _settings;

        public SettingManager(ApplicationSettingsBase settings)
        {
            _settings = settings;
        }

        public TSetting Get<TSetting>(string settingName)
        {
            if (!Contains(settingName))
            {
                return default(TSetting);
            }

            object setting = _settings[settingName];

            if (setting is TSetting)
            {
                return (TSetting)setting;
            }

            Console.WriteLine($"Setting {settingName} is not of type {typeof(TSetting)}");
            return default(TSetting);
        }

        public string GetAndDecrypt(string settingName, string entropyName)
        {
            if (!Contains(settingName)) return null;

            if (!Contains(entropyName)) return null;

            string cypherText = _settings[settingName] as string;
            string entropy = _settings[entropyName] as string;

            return Encryption.Decrypt(cypherText, entropy);
        }

        public void Update<TSetting>(string settingName, TSetting settingValue)
        {
            if (!Contains(settingName)) return;

            _settings[settingName] = settingValue;
            _settings.Save();
        }

        public void Save(string settingName, string value)
        {
            _settings[settingName] = value;
            _settings.Save();
        }

        public void SaveAsEncrypted(
            string settingName, 
            string settingEntropyName, 
            string plainTextValue)
        {
            (string cypherText, string entropy) = Encryption.Encrypt(plainTextValue);

            _settings[settingName]= cypherText;
            _settings[settingEntropyName] = entropy;

            _settings.Save();
        }

        private bool Contains(string settingName)
        {
            if (_settings[settingName] == null)
            {
                Console.WriteLine($"App does not contain setting {settingName}");
                return false;
            }

            if (!(_settings[settingName] is string))
            {
                Console.WriteLine($"Setting {settingName} is not of type string");
                return false;
            }

            if (string.IsNullOrEmpty(_settings[settingName] as string))
            {
                Console.WriteLine($"Setting {settingName} is null or empty");
                return false;
            }

            return true;
        }
    }
}
