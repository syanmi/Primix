using System;

namespace Primix.Disposable
{
    public interface IDisposableCollection : IDisposable
    {
        void Add(IDisposable disposable);
    }
}
