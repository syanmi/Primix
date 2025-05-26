using System;
using System.Threading;
using System.Threading.Tasks;

namespace Primix.Async
{
    public class CancellableTask : Task
    {
        private CancellationTokenSource _source;

        public CancellationTokenSource Source => _source;

        public CancellableTask(Action action) : base(action)
        {
            _source = new CancellationTokenSource();
        }

        public void Cancel() => _source?.Cancel();

        public static CancellableTask CancellableRun(Action action)
        {
            var task = new CancellableTask(action);
            task.Start();
            return task;
        }

        public static CancellableTask<T> CancellableRun<T>(Func<T> action)
        {
            var task = new CancellableTask<T>(action);
            task.Start();
            return task;
        }
    }
}
