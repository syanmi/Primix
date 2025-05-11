using Primix.Data;

namespace Primix.Config
{
    public interface IConfig<T> : IReadOnlyConfig<T>, IEditableData<T>
    {
        void Save();
        void Load();
    }
}
