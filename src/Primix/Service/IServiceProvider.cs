using System.Collections.Generic;

namespace Primix.Service
{
    public interface IServiceProvider
    {
        TService GetService<TService>();
    }
}
