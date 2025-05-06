using System;
using System.Threading;
using System.Threading.Tasks;

namespace Primix.Command
{
    public sealed class AsyncCommand : AsyncCommand<object>, IAsyncCommand
    {
        public AsyncCommand(Func<object, Task> execute) : base(execute)
        {
        }

        public AsyncCommand(Func<object, CancellationToken, Task> execute) : base(execute)
        {
        }

        public AsyncCommand(Func<object, CancellationToken, IProgress<double>, Task> execute) : base(execute)
        {
        }
    }
}
