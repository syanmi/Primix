
namespace Primix.View
{
    public interface IWindow
    {
        string Name { get; }
        IWindow Parent { get; }
        IWindow[] Children { get; }
        bool IsVisible { get; }
        void Activate();
        void Minimize();
        void Maximize();
        void Show();
        WindowResult ShowDialog();
        void Close();
    }
}
