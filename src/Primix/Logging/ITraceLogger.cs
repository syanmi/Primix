
namespace Primix.Logging
{
    public interface ITraceLogger
    {
        void Log(TraceLogLevel level, string message);
    }
    public interface ITraceLogger<out T> : ITraceLogger
    {
    }
}
