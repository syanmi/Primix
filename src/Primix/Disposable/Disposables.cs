using System;

namespace Primix.Disposable
{
    public static class Disposables
    {
        public static IDisposable Noop { get; } = new NullDisposable();

        public static IDisposable Action(Action action)
        {
            return new DisposableAction(action);
        }

        public static IRefCountDisposable Create(IDisposable disposable)
        {
            return new RefCountDisposable(disposable);
        }
    }
}
