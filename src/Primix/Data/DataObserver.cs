using System;

namespace Primix.Data
{
    internal class DataObserver<T> : IObserver<T>
    {
        private Action _completed;
        private Action<Exception> _error;
        private Action<T> _next;

        public DataObserver(Action completed, Action<Exception> error, Action<T> next)
        {
            _completed = completed;
            _error = error;
            _next = next;
        }

        public void OnCompleted()
        {
            _completed?.Invoke();
        }

        public void OnError(Exception error)
        {
            _error?.Invoke(error);
        }

        public void OnNext(T value)
        {
            _next?.Invoke(value);
        }
    }
}
