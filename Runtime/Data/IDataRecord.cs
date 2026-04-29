namespace DRG.Data
{
    public interface IDataRecord
    {
        string key { get; }
        bool hasValue { get; }
        bool isDirty { get; }
        bool processed { get; }
        void Apply();
        void Erase();
    }
}
