using System;
using System.Threading.Tasks;

namespace Primix.Command
{
    public interface ICommandFactory
    {
        ICommand Create(Action<object> execute, Func<object, bool> canExecute = null);
        ICommand<T> Create<T>(Action<T> execute, Func<T, bool> canExecute = null);
        ICommand<T, TResult> Create<T, TResult>(Func<T, TResult> execute, Func<T, bool> canExecute = null);

        IAsyncCommand Create(Func<object, Task> execute, Func<bool> canExecute = null);
        IAsyncCommand<T> Create<T>(Func<T, Task> execute, Func<bool> canExecute = null);
        IAsyncCommand<T, TResult> Create<T, TResult>(Func<T, Task<TResult>> execute, Func<bool> canExecute = null);
    }
}
