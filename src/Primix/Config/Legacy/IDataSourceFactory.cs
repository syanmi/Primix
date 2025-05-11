
namespace Primix.Config.Legacy
{
    interface IDataSourceFactory
    {
        IDataSource Create(string name);
    }
}
