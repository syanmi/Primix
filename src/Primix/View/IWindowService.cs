using System.Collections.Generic;

namespace Primix.View
{
    public interface IWindowService
    {
        IEnumerable<IWindow> GetAllWindow();
        IWindow GetTopLevelWindow();
        void SetActiveWindow(IWindow window);
    }
}
