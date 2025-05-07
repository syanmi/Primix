using System;
using System.Collections.Generic;

namespace Primix.Disposable
{
    internal sealed class DisposableCollection : IDisposable
    {
        private List<IDisposable> _disposables;
        private bool _disposed;

        public DisposableCollection()
        {
            _disposables = new List<IDisposable>();
        }

        public void Add(IDisposable disposable)
        {
            if (disposable == null) return;

            if (_disposed)
            {
                // すでにDispose済みなら即座に破棄
                disposable.Dispose();
            }
            else
            {
                _disposables.Add(disposable);
            }
        }

        public static DisposableCollection operator +(DisposableCollection collection, IDisposable disposable)
        {
            collection.Add(disposable);
            return collection;
        }

        public void Dispose()
        {
            if (_disposed) return;

            foreach (var d in _disposables)
            {
                d.Dispose();
            }

            _disposables.Clear();
            _disposed = true;
        }
    }
}
