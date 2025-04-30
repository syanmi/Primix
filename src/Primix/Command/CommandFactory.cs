using System;
using System.Threading.Tasks;

namespace Primix.Command
{
    internal class CommandFactory
    {
        public ICommand Create(Action<object> execute, Func<object, bool> canExecute = null)
        {
            return new RelayCommand(execute, canExecute);
        }

        public ICommand<T> Create<T>(Action<T> execute, Func<T, bool> canExecute = null)
        {
            return new RelayCommand<T>(execute, canExecute);
        }

        public ICommand<T, TResult> Create<T, TResult>(Func<T, TResult> execute, Func<T, bool> canExecute = null)
        {
            return new RelayCommand<T, TResult>(execute, canExecute);
        }

        public IAsyncCommand Create(Func<object, Task> execute, Func<bool> canExecute = null)
        {
            return new AsyncCommand(execute, canExecute);
        }

        public IAsyncCommand<T> Create<T>(Func<T, Task> execute, Func<bool> canExecute = null)
        {
            return new AsyncCommand<T>(execute, canExecute);
        }

        public IAsyncCommand<T, TResult> Create<T, TResult>(Func<T, Task<TResult>> execute, Func<bool> canExecute = null)
        {
            return new AsyncCommand<T, TResult>(execute, canExecute);
        }
    }
}
