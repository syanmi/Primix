using System;
using System.Threading;

namespace Primix.Disposable
{
    internal sealed class RefCountDisposable : IRefCountDisposable, IDisposable
    {
        private readonly IDisposable _inner;
        private int _refCount;
        private bool _disposed;

        public RefCountDisposable(IDisposable inner)
        {
            _inner = inner ?? throw new ArgumentNullException(nameof(inner));
            _refCount = 1;
        }

        public IDisposable GetDisposable()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(RefCountDisposable));

            Interlocked.Increment(ref _refCount);

            return new InnerDisposable(this);
        }

        public void Dispose()
        {
            if (_disposed) return;
            
            if (Release() == 0)
            {
                _inner.Dispose();
                _disposed = true;
            }
        }

        private int Release()
        {
            return Interlocked.Decrement(ref _refCount);
        }

        private class InnerDisposable : IDisposable
        {
            private RefCountDisposable _owner;

            public InnerDisposable(RefCountDisposable owner)
            {
                _owner = owner;
            }

            public void Dispose()
            {
                _owner?.Release();
                _owner = null;
            }
        }
    }
}
