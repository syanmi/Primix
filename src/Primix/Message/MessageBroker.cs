using Primix.Disposable;
using System;
using System.Collections.Generic;

namespace Primix.Message
{
    internal class MessageBroker<T> : IMessageBroker<T>
    {
        private List<IMessageHandler<T>> _handlers;

        public MessageBroker()
        {
            _handlers = new List<IMessageHandler<T>>();
        }

        public void Publish(T message)
        {
            foreach(var handler in _handlers)
            {
                handler?.Handle(message);
            }
        }

        public IDisposable Subscribe(IMessageHandler<T> handler)
        {
            _handlers.Add(handler);

            return new MessageSubscription<T>(this, handler);
        }

        public void Unsubscribe(IMessageHandler<T> handler)
        {
            _handlers.Remove(handler);
        }
    }
}
