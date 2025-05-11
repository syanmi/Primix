using System;
using System.Collections.Generic;
using System.Text;

namespace Primix.Data
{
    internal class DataEditor<T> : IDataEditor<T>
    {
        private T _data;
        private Action<T> _commit;

        public T Value => _data;

        public DataEditor(T data, Action<T> commit)
        {
            _data = data;
            _commit = commit;
        }

        public void Commit()
        {
            _commit?.Invoke(_data);
        }
    }
}
