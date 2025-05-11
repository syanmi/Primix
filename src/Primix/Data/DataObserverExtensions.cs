using System;

namespace Primix.Data
{
    public static class DataObserverExtensions
    {
        public static IDisposable Subscribe<T>(this IObservable<T> observable, Action<T> next)
        {
            return observable.Subscribe(new DataObserver<T>(null, null, next));
        }
    }
}
