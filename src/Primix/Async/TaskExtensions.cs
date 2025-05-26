using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Primix.Async
{
    public static partial class TaskExtensions
    {
        // WithCancellation
        public static async Task WithCancellation(this Task task, CancellationToken cancellationToken)
        {
            var tcs = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => tcs.TrySetResult(true)))
            {
                if (task == await Task.WhenAny(task, tcs.Task).ConfigureAwait(false))
                {
                    await task.ConfigureAwait(false);
                }
                else
                {
                    cancellationToken.ThrowIfCancellationRequested();
                }
            }
        }

        public static async Task<T> WithCancellation<T>(this Task<T> task, CancellationToken cancellationToken)
        {
            await WithCancellation((Task)task, cancellationToken).ConfigureAwait(false);
            return await task.ConfigureAwait(false);
        }


        // WithTimeout
        public static async Task WithTimeout(this Task task, TimeSpan timeout, CancellationToken cancellationToken = default)
        {
            using (var timeoutCts = new CancellationTokenSource(timeout))
            using (var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(timeoutCts.Token, cancellationToken))
            {
                var tcs = new TaskCompletionSource<bool>();
                using (linkedCts.Token.Register(() => tcs.TrySetResult(true)))
                {
                    if (task == await Task.WhenAny(task, tcs.Task).ConfigureAwait(false))
                    {
                        await task.ConfigureAwait(false);
                    }
                    else
                    {
                        throw new TimeoutException();
                    }
                }
            }
        }

        public static async Task<T> WithTimeout<T>(this Task<T> task, TimeSpan timeout, CancellationToken cancellationToken = default)
        {
            await WithTimeout((Task)task, timeout, cancellationToken).ConfigureAwait(false);
            return await task.ConfigureAwait(false);
        }


        // AndForget
        public static void AndForget(
            this Task task,
            Action<Exception> onException = null)
        {
            task.ContinueWith(t =>
            {
                if (t.IsFaulted && t.Exception != null)
                {
                    onException?.Invoke(t.Exception.InnerException ?? t.Exception);
                }
            }, TaskContinuationOptions.OnlyOnFaulted);
        }

        public static void AndForget<T>(this Task<T> task, Action<Exception> onException = null) => AndForget((Task)task, onException);


        // IgnoreException
        public static async Task IgnoreExceptions(this Task task)
        {
            try
            {
                await task.ConfigureAwait(false);
            }
            catch // ignore
            {
            }
        }
        public static async Task<T> IgnoreExceptions<T>(this Task<T> task)
        {
            try
            {
                return await task.ConfigureAwait(false);
            }
            catch // ignore
            {
                return default;
            }
        }
    }
}
