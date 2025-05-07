using System;

namespace Primix.Message
{
    internal class MessageSubscriber<T> : IMessageSubscriber<T>
    {
        private IMessageBroker<T> _broker;

        public MessageSubscriber(IMessageBroker<T> broker)
        {
            _broker = broker;
        }

        public IDisposable Subscribe(IMessageHandler<T> handler) => _broker?.Subscribe(handler);
    }
}
