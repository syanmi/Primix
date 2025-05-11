using System;
using System.Collections.Generic;

namespace Primix.Data
{
    internal class SharedDataSource : ISharedDataSource
    {
        private Dictionary<Type, object> _objects;

        public SharedDataSource()
        {
            _objects = new Dictionary<Type, object>();
        }

        public T GetData<T>() where T : class, new()
        {
            if(_objects.TryGetValue(typeof(T), out var data))
            {
                return (T)data;
            }

            var created = new T();
            _objects.Add(typeof(T), created);
            return created;
        }

        public void SetData<T>(T data) where T : class, new()
        {
            _objects.Remove(typeof(T));
            _objects.Add(typeof(T), data);
        }
    }
}
