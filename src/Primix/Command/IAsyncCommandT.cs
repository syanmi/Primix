using System.Threading.Tasks;

namespace Primix.Command
{
    public interface IAsyncCommand<T> : ICommand<T>
    {
        Task ExecuteAsync(T parameter = default);
    }
}
