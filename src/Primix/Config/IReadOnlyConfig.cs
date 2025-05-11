using Primix.Data;

namespace Primix.Config
{
    public interface IReadOnlyConfig<T> : IReadableData<T>, IObservableData<T>
    {
    }
}
