
namespace Primix.Message
{
    public interface IMessageHandler<T>
    {
        void Handle(T message);
    }
}
