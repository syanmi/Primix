
namespace Primix.Message
{
    internal class MessagePublisher<T> : IMessagePublisher<T>
    {
        private IMessageBroker<T> _broker;

        public MessagePublisher(IMessageBroker<T> broker)
        {
            _broker = broker;
        }

        public void Publish(T message) => _broker?.Publish(message);
    }
}
