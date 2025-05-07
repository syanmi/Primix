using System;

namespace Primix.Disposable
{
    internal sealed class NullDisposable : IDisposable
    {
        public void Dispose()
        {
        }
    }
}
