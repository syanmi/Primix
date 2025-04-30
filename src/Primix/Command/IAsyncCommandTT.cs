using System.Threading.Tasks;

namespace Primix.Command
{
    public interface IAsyncCommand<T, TResult> : ICommand<T>
    {
        Task<TResult> ExecuteAsync(T parameter = default);
    }
}
