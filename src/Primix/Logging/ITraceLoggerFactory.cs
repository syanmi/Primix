
namespace Primix.Logging
{
    public interface ITraceLoggerFactory
    {
        ITraceLogger CreateLogger(string categoryName);
    }
}
