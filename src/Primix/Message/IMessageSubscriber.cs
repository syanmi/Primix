using System;

namespace Primix.Message
{
    public interface IMessageSubscriber<T>
    {
        IDisposable Subscribe(IMessageHandler<T> handler);
    }
}
