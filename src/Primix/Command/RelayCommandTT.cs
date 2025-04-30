using System;

namespace Primix.Command
{
    public class RelayCommand<T, TResult> : ICommand<T, TResult>
    {
        private readonly Func<T, TResult> _execute;
        private readonly Func<T, bool> _canExecute;

        public RelayCommand(Func<T, TResult> execute, Func<T, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(T parameter) => _canExecute?.Invoke(parameter) ?? true;
        public TResult Execute(T parameter) => _execute(parameter);

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
