using System;

namespace Primix.Message
{
    internal class MessageHandler<T> : IMessageHandler<T>
    {
        private Action<T> _handler;

        public MessageHandler(Action<T> handler)
        {
            _handler = handler;
        }

        public void Handle(T message)
        {
            _handler?.Invoke(message);
        }
    }
}
