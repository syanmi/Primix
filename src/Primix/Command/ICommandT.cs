using System;

namespace Primix.Command
{
    public interface ICommand<T>
    {
        event EventHandler CanExecuteChanged;
        bool CanExecute(T parameter = default);
        void Execute(T parameter = default);
    }
}
