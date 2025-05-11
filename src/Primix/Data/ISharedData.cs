using System;

namespace Primix.Data
{
    public interface ISharedData<T> : IReadableData<T>, IObservableData<T>, IEditableData<T>
    {
    }

    public interface IReadableData<T>
    {
        T Value { get; }
    }

    public interface IObservableData<T> : IObservable<T>
    {
    }

    public interface IEditableData<T>
    {
        IDataEditor<T> GetEditor();
    }

    public interface IDataEditor<T>
    {
        T Value { get; }

        void Commit();
    }

}
