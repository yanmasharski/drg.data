namespace DRG.Data
{
    using DRG.Serialization;

    public interface IDataStorage
    {
        bool ContainsKey(string key);
        ITypedDataRecord<bool> GetBool(string key, bool defaultVal = false);
        ITypedDataRecord<int> GetInt(string key, int defaultVal = 0);
        ITypedDataRecord<float> GetFloat(string key, float defaultVal = 0f);
        ITypedDataRecord<string> GetString(string key, string defaultVal = "");
        ITypedDataRecord<T> GetObject<T>(string key, T defaultVal, IDataSerializer serializer);
        void Erase(string key);
        void EraseAll();
        void Save(int framesCooldown = 60);
    }
}
