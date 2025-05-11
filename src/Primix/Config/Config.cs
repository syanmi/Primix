using Primix.Data;
using Primix.Disposable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Primix.Config
{
    internal sealed class Config<T> : IConfig<T> where T : class, new()
    {
        private List<IObserver<T>> _observers;
        private IDataSource _source;

        public T Value => _source.GetData<T>();

        public Config(IDataSource source)
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

                    foreach (var observer in _observers)
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

        public void Save()
        {

        }

        public void Load()
        {

        }
    }
}
