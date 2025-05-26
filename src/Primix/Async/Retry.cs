using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Primix.Async
{
    public static class Retry
    {

        public static Task WithRetry(Func<CancellationToken, Task> action, int retry, CancellationToken cancellationToken = default)
            => WithRetry(action, retry, TimeSpan.Zero, cancellationToken);
        public static Task WithRetry(
            Func<CancellationToken, Task> action,
            int retry,
            TimeSpan delay,
            CancellationToken cancellationToken = default)
        {
            return WithRetry(async token =>
            {
                await action(token).ConfigureAwait(false);
                return Unit.Value;
            }, retry, delay, cancellationToken);
        }


        public static Task<T> WithRetry<T>(Func<CancellationToken, Task<T>> action, int retry, CancellationToken cancellationToken = default)
            => WithRetry<T>(action, retry, TimeSpan.Zero, cancellationToken);
        public static async Task<T> WithRetry<T>(
            Func<CancellationToken, Task<T>> action,
            int retry,
            TimeSpan delay,
            CancellationToken cancellationToken = default)
        {
            for (int attempt = 1; ; attempt++)
            {
                try
                {
                    await action(cancellationToken).ConfigureAwait(false);
                }
                catch (OperationCanceledException)
                {
                    throw;
                }
                catch when (attempt <= retry)
                {
                    await Task.Delay(delay).ConfigureAwait(false);
                }
            }
        }

    }
}
