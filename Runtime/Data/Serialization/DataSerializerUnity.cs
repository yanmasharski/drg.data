namespace DRG.Serialization
{
    using System;
    using UnityEngine;

    public class DataSerializerUnity : IDataSerializer
    {
        public string Serialize<T>(T obj) => JsonUtility.ToJson(obj);
        public T Deserialize<T>(string data) => JsonUtility.FromJson<T>(data);
        public object Deserialize(Type type, string data) => JsonUtility.FromJson(data, type);
        public string Serialize(Type type, object obj) => JsonUtility.ToJson(obj);
    }
}
