using System;

namespace Primix.Command
{
    public interface ICommand<T, TResult>
    {
        event EventHandler CanExecuteChanged;
        bool CanExecute(T parameter = default);
        TResult Execute(T parameter = default);
    }
}
