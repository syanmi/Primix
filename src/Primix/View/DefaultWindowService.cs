using System.Collections.Generic;

namespace Primix.View
{
    internal class DefaultWindowService : IWindowService
    {
        private IWindow[] _windows = new IWindow[] { new DefaultWindow() };

        public IEnumerable<IWindow> GetAllWindow() => _windows;

        public IWindow GetTopLevelWindow() => _windows[0];

        public void SetActiveWindow(IWindow window)
        {
        }
    }
}
