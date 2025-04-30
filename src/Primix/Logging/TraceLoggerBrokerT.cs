
namespace Primix.Logging
{
    internal class TraceLoggerBrokerT<T> : ITraceLogger<T>
    {
        private ITraceLogger _logger;

        public TraceLoggerBrokerT(ITraceLoggerFactory factory)
        {
            _logger = factory.CreateLogger(typeof(T).ToString());
        }

        public void Log(TraceLogLevel level, string message) => _logger.Log(level, message);
    }
}
