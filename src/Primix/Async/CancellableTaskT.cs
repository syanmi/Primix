using System;
using System.Threading;
using System.Threading.Tasks;

namespace Primix.Async
{
    public class CancellableTask<T> : Task<T>
    {
        private CancellationTokenSource _source;

        public CancellationTokenSource Source => _source;

        public CancellableTask(Func<T> action) : base(action)
        {
            _source = new CancellationTokenSource();
        }

        public void Cancel() => _source?.Cancel();
    }
}
