
namespace Primix.Data
{
    public interface IReadOnlyDataSource
    {
        T GetSection<T>() where T : new();
    }
}
