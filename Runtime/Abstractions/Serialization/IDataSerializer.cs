namespace DRG.Data.Serialization
{
    using System;

    public interface IDataSerializer
    {
        string Serialize<T>(T obj);
        T Deserialize<T>(string data);
        object Deserialize(Type type, string data);
        string Serialize(Type type, object obj);
    }
}
