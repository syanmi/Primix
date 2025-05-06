using System;
using System.Threading;
using System.Threading.Tasks;

namespace Primix.Command
{
    public abstract class AsyncCommandBase<T, TResult> : IAsyncCommand<T, TResult>
    {
        private readonly bool _allowConcurrent;
        private bool _isRunning;
        private CancellationTokenSource _cts;

        public bool SupportCancel { get; private set; }
        public bool SupportProgress { get; private set; }

        public event EventHandler CanExecuteChanged;
        public event Action<double> ProgressChanged;

        protected AsyncCommandBase(bool supportCancel, bool supportProgress, bool allowConcurrent = false)
        {
            SupportCancel = supportCancel;
            SupportProgress = supportProgress;
            _allowConcurrent = allowConcurrent;
        }

        public bool CanExecute(T parameter) => (!_isRunning || _allowConcurrent) && (InternalCanExecute());

        void ICommand<T>.Execute(T parameter)
        {
            _ = ExecuteAsync(parameter);
        }

        public async Task<TResult> ExecuteAsync(T parameter = default)
        {
            if (!CanExecute(parameter)) throw new InvalidOperationException();

            _cts = new CancellationTokenSource();
            var progress = new Progress<double>(p => ProgressChanged?.Invoke(p));
            _isRunning = true;
            RaiseCanExecuteChanged();

            try
            {
                return await InternalExecuteAsync(parameter, _cts.Token, progress);
            }
            finally
            {
                _isRunning = false;
                _cts.Dispose();
                _cts = null;
                RaiseCanExecuteChanged();
            }
        }

        public void Cancel() => _cts?.Cancel();
        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        protected abstract Task<TResult> InternalExecuteAsync(T parameter, CancellationToken token, IProgress<double> progress);
        protected abstract bool InternalCanExecute(T parameter = default);
    }
}
