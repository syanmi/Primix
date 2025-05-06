using System;
using System.Threading;
using System.Threading.Tasks;

namespace Primix.Command
{
    public class AsyncCommand<T> : AsyncCommandBase<T>
    {
        private readonly Func<T, CancellationToken, IProgress<double>, Task> _execute;
        private readonly Func<object, bool> _canExecute;

        public AsyncCommand(Func<T, Task> execute, Func<object, bool> canExecute = null) : base(false, false)
        {
            _execute = (param, token, report) => execute(param);
            _canExecute = canExecute;
        }

        public AsyncCommand(Func<T, CancellationToken, Task> execute, Func<object, bool> canExecute = null) : base(true, false)
        {
            _execute = (param, token, report) => execute(param, token);
            _canExecute = canExecute;
        }

        public AsyncCommand(Func<T, CancellationToken, IProgress<double>, Task> execute, Func<object, bool> canExecute = null) : base(true, true)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        protected override Task InternalExecuteAsync(T parameter, CancellationToken token, IProgress<double> progress) => _execute(parameter, token, progress);
        protected override bool InternalCanExecute(T parameter = default) => _canExecute?.Invoke(parameter) ?? true;
    }
}
