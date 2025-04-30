
namespace Primix.View
{
    public interface IWindow
    {
        string Name { get; }
        IWindow Parent { get; }
        IWindow[] Children { get; }
        void Minimize();
        void Maximize();
        void Close();
    }
}
