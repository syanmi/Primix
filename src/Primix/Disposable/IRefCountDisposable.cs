using System;

namespace Primix.Disposable
{
    public interface IRefCountDisposable
    {
        IDisposable GetDisposable();
    }
}
