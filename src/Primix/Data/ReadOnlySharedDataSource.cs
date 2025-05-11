using System;
using System.Collections.Generic;

namespace Primix.Data
{
    internal class ReadOnlySharedDataSource : IReadOnlySharedDataSource
    {
        private Dictionary<Type, object> _readOnlyObjects;
        private ISharedDataSource _dataSource;

        public ReadOnlySharedDataSource(ISharedDataSource dataSource)
        {
            _readOnlyObjects = new Dictionary<Type, object>();
            _dataSource = dataSource;
        }

        public T GetData<T>() where T : class, new()
        {
            if (_readOnlyObjects.TryGetValue(typeof(T), out var readOnlyData))
            {
                return (T)readOnlyData;
            }

            var data = _dataSource.GetData<T>();
            if(data != null)
            {
                return data;
            }

            throw new InvalidOperationException();
        }

        public void SetData<T>(T data) where T : class, new()
        {
            _readOnlyObjects.Remove(typeof(T));
            _readOnlyObjects.Add(typeof(T), data);
        }
    }
}
