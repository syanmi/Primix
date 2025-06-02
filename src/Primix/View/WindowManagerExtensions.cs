using System.Linq;

namespace Primix.View
{
    public static class WindowManagerExtensions
    {
        public static IWindow GetTopLevelWindow(this IWindowManager manager)
        {
            var windows = manager.GetOpenWindows();
            return windows.FirstOrDefault(x => x.Parent == null);
        }
    }
}
