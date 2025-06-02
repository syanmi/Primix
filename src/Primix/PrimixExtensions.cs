using Primix.Command;
using Primix.Config;
using Primix.Data;
using Primix.Logging;
using Primix.Message;
using Primix.Service;
using Primix.View;

namespace Primix
{
    public static class PrimixExtensions
    {
        public static void AddPrimix(this IServiceCollection collection)
        {
            collection.AddPrimixCommand();
            collection.AddPrimixLogging();
            collection.AddPrimixView();

            collection.AddSingleton(typeof(IMessageBroker<>), typeof(MessageBroker<>));
            collection.AddSingleton(typeof(IMessagePublisher<>), typeof(MessagePublisher<>));
            collection.AddSingleton(typeof(IMessageSubscriber<>), typeof(MessageSubscriber<>));

            collection.AddSingleton(typeof(ISharedData<>), typeof(SharedData<>));
            collection.AddSingleton(typeof(IReadOnlySharedData<>), typeof(ReadOnlySharedData<>));
            collection.AddSingleton(typeof(ISharedDataSource), typeof(SharedDataSource));
            collection.AddSingleton(typeof(IReadOnlySharedDataSource), typeof(ReadOnlySharedDataSource));
            collection.AddSingleton(typeof(IReadOnlyConfig<>), typeof(IConfig<>));

        }

        public static void AddPrimixCommand(this IServiceCollection collection)
        {
            collection.AddSingleton<ICommandFactory, CommandFactory>();
        }

        public static void AddPrimixLogging(this IServiceCollection collection)
        {
            collection.AddSingleton<ITraceLoggerFactory, TraceLoggerFactory>();
            collection.AddSingleton<ITraceLogger, TraceLoggerFactory>();
        }

        public static void AddPrimixView(this IServiceCollection collection)
        {
            //collection.AddSingleton<IWindowService, DefaultWindowService>();
            //collection.AddSingleton<IMessageDialogService, DefaultDialogService>();
        }
    }
}
