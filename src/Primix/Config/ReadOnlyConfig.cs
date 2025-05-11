using Primix.Data;
using Primix.Disposable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Primix.Config
{
    internal class ReadOnlyConfig<T> : IReadOnlyConfig<T>
    {
        private T _data;

        public T Value => _data;

        public ReadOnlyConfig(T data)
        {
            _data = data;
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            return Disposables.Noop;
        }
    }
}
