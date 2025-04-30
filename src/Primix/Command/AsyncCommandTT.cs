using System;
using System.Threading.Tasks;

namespace Primix.Command
{
    public class AsyncCommand<T, TResult> : IAsyncCommand<T, TResult>
    {
        private readonly Func<T, Task<TResult>> _execute;
        private readonly Func<bool> _canExecute;
        private bool _isExecuting;

        public event EventHandler CanExecuteChanged;

        public AsyncCommand(Func<T, Task<TResult>> execute, Func<bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(T parameter) => !_isExecuting && (_canExecute?.Invoke() ?? true);

        public void Execute(T parameter)
        {
            _ = ExecuteAsync(parameter);
        }

        public async Task<TResult> ExecuteAsync(T parameter)
        {
            _isExecuting = true;
            RaiseCanExecuteChanged();
            try
            {
                return await _execute(parameter);
            }
            finally
            {
                _isExecuting = false;
                RaiseCanExecuteChanged();
            }
        }

        protected void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
