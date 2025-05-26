namespace Primix.Async
{
    public sealed class AsyncLock : AsyncThrottle
    {
        public AsyncLock() : base(1)
        {
        }
    }
}
