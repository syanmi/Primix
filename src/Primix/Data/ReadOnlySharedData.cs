using System;

namespace Primix.Data
{
    internal class ReadOnlySharedData<T> : IReadOnlySharedData<T> where T : class, new()
    {
        private IReadOnlySharedDataSource _source;

        public T Value => _source.GetData<T>();

        public ReadOnlySharedData(IReadOnlySharedDataSource source)
        {
            _source = source;
        }
    }
}
