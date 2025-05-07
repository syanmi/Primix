
namespace Primix.Message
{
    public interface IMessagePublisher<T>
    {
        void Publish(T message);
    }
}
