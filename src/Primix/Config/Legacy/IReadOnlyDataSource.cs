
namespace Primix.Config.Legacy
{
    public interface IReadOnlyDataSource
    {
        T GetSection<T>() where T : new();
    }
}
