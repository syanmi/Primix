using Primix.Disposable;
using System;
using System.Collections.Generic;

namespace Primix.Data
{
    internal class SharedData<T> : ISharedData<T> where T : class, new()
    {
        private List<IObserver<T>> _observers;
        private ISharedDataSource _source;

        public T Value => _source.GetData<T>();

        public SharedData(ISharedDataSource source)
        {
            _observers = new List<IObserver<T>>();
            _source = source;
        }

        public IDataEditor<T> GetEditor()
        {
            return new DataEditor<T>(
                _source.GetData<T>(),
                (data) =>
                {
                    _source.SetData(data);

                    foreach(var observer in _observers)
                    {
                        observer?.OnNext(data);
                    }
                });
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return Disposables.Action(() => _observers?.Remove(observer));
        }
    }
}
