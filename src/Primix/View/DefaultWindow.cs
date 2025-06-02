
namespace Primix.View
{
    internal class DefaultWindow : IWindow
    {
        public string Name => "Default Window";

        public IWindow Parent => null;

        public IWindow[] Children => new IWindow[0];

        public bool IsVisible => throw new System.NotImplementedException();

        public void Activate()
        {
            throw new System.NotImplementedException();
        }

        public void Close()
        {
        }

        public void Maximize()
        {
        }

        public void Minimize()
        {
        }

        public void Show()
        {
            throw new System.NotImplementedException();
        }

        public WindowResult ShowDialog()
        {
            throw new System.NotImplementedException();
        }
    }
}
