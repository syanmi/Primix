using System;

namespace Primix.Logging
{
    public class SimpleTraceLogger : TraceLoggerBase
    {
        public SimpleTraceLogger(string category) : base(category)
        {
        }

        protected override void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
