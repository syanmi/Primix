using System.Threading.Tasks;

namespace Primix.Command
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync(object parameter = default);
    }
}
