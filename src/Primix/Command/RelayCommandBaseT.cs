using System;

namespace Primix.Command
{
    public abstract class RelayCommandBase<T> : ICommand<T>
    {
        public event EventHandler CanExecuteChanged;

        protected abstract bool CanExecute(T parameter);
        protected abstract void Execute(T parameter);

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        bool ICommand<T>.CanExecute(T parameter) => CanExecute(parameter);

        void ICommand<T>.Execute(T parameter) => Execute(parameter);
    }
}
