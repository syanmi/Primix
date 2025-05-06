using System;

namespace Primix.Command
{
    public abstract class RelayCommandBase<T, TResult> : ICommand<T, TResult>
    {
        public event EventHandler CanExecuteChanged;

        protected abstract bool CanExecute(T parameter);
        protected abstract TResult Execute(T parameter);

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        bool ICommand<T, TResult>.CanExecute(T parameter) => CanExecute(parameter);

        TResult ICommand<T, TResult>.Execute(T parameter) => Execute(parameter);
    }
}
