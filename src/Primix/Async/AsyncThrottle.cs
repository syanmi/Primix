using Primix.Disposable;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Primix.Async
{
    public class AsyncThrottle
    {
        private readonly SemaphoreSlim _semaphore;

        public AsyncThrottle(int count)
        {
            _semaphore = new SemaphoreSlim(count, count);
        }

        public async Task<IDisposable> LockAsync()
        {
            await _semaphore.WaitAsync().ConfigureAwait(false);

            return Disposables.Action(() =>
            {
                _semaphore?.Release();
            });
        }
    }
}
