namespace CoreySutton.Utilities
{
    public interface ISettingManager
    {
        TSetting Get<TSetting>(string settingName);
        string GetAndDecrypt(string settingName, string entropyName);
        void Save(string settingName, string value);
        void SaveAsEncrypted(string settingName, string settingEntropyName, string plainTextValue);
        void Update<TSetting>(string settingName, TSetting settingValue);
    }
}