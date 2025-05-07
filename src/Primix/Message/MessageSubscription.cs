using System;

namespace Primix.Message
{
    internal class MessageSubscription<T> : IDisposable
    {
        private readonly MessageBroker<T> _broker;
        private readonly IMessageHandler<T> _handler;

        public MessageSubscription(MessageBroker<T> broker, IMessageHandler<T> handler)
        {
            _broker = broker;
            _handler = handler;
        }

        public void Dispose()
        {
            _broker.Unsubscribe(_handler);
        }
    }
}
