
namespace Primix.Message
{
    public interface IMessageBroker<T> : IMessagePublisher<T>, IMessageSubscriber<T>
    {
    }
}
