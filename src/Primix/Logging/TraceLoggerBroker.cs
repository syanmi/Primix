using System;
using System.Collections.Generic;
using System.Text;

namespace Primix.Logging
{
    internal class TraceLoggerBroker : ITraceLogger
    {
        private ITraceLogger _logger;

        public TraceLoggerBroker(ITraceLoggerFactory factory)
        {
            _logger = factory.CreateLogger("");
        }

        public void Log(TraceLogLevel level, string message) => _logger.Log(level, message);
    }
}
