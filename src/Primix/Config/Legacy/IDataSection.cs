
namespace Primix.Config.Legacy
{
    public interface IDataSection<T>
    {
        T Value { get; }

        void Load();

        void Save();
    }
}
