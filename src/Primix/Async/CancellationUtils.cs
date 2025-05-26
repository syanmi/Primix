using System;
using System.Threading;

namespace Primix.Async
{
    public static class CancellationUtils
    {
        public static CancellationTokenSource CreateLinkedSource(params CancellationToken[] tokens)
            => CancellationTokenSource.CreateLinkedTokenSource(tokens);

        public static IDisposable CreateScopedToken(out CancellationToken token, TimeSpan timeout = default)
        {
            var cts = ((timeout == null) || (timeout == TimeSpan.Zero))
                ? new CancellationTokenSource()
                : new CancellationTokenSource(timeout);

            token = cts.Token;
            return cts;
        }
    }
}
