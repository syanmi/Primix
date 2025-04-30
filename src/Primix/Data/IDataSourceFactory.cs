
namespace Primix.Data
{
    interface IDataSourceFactory
    {
        IDataSource Create(string name);
    }
}
