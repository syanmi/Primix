using System;
using System.Collections.Generic;
using System.Text;

namespace Primix.Data
{
    class DataAccessor<T> where T : class, new()
    {
        private IDataSource _source;

        public DataAccessor(IDataSource source)
        {
            _source = source;
        }

        public T GetValue() => _source.GetData<T>();
    }
}
