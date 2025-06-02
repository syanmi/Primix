using System;
using Primix.Service;

namespace WindowsFormsSample.App
{
    static class AppServices
    {
        private static IServiceProvider _provider;

        public static IServiceProvider Provider => _provider;

        public static void Load(IServiceCollection services) => _provider = services.BuildServiceProvider();

        public static T Require<T>() where T : class => Provider?.GetService<T>();
    }
}
