namespace DRG.Data
{
    public interface ITypedDataRecord<T> : IDataRecord
    {
        void SetValue(T value);
        T GetValue();
    }
}
