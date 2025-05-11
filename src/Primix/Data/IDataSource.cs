
namespace Primix.Data
{
    public interface IDataSource
    {
        T GetData<T>() where T : class, new();

        void SetData<T>(T data) where T : class, new();
    }
}
