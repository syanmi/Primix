
namespace Primix.View
{
    internal class DefaultWindow : IWindow
    {
        public string Name => "Default Window";

        public IWindow Parent => null;

        public IWindow[] Children => new IWindow[0];

        public void Close()
        {
        }

        public void Maximize()
        {
        }

        public void Minimize()
        {
        }
    }
}
