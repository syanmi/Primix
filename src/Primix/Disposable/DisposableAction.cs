using System;

namespace Primix.Disposable
{
    internal sealed class DisposableAction : IDisposable
    {
        private Action _dispose;
        private bool _disposed;

        public DisposableAction(Action dispose)
        {
            _dispose = dispose;
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _dispose?.Invoke();
                _disposed = true;
            }
        }
    }
}
