using Primix.Command;
using Primix.Logging;
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
            collection.AddSingleton<IWindowService, DefaultWindowService>();
            collection.AddSingleton<IDialogService, DefaultDialogService>();
        }
    }
}
