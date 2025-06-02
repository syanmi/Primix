using System.Collections.Generic;

namespace Primix.View
{
    public interface IWindowManager
    {
        IReadOnlyList<IWindow> GetOpenWindows();
        IWindow GetActiveWindow();
    }
}
