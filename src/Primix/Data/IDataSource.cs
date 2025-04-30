
namespace Primix.Data
{
    public interface IDataSource : IReadOnlyDataSource
    {
        void SetSection<T>(T section) where T : new();
        void Save();
    }
}
