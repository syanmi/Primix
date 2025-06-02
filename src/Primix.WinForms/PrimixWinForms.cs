using Primix.Service;
using Primix.View;
using Primix.WinForms.Service.View;

namespace Primix
{
    public static class PrimixExtensions
    {
        public static void AddPrimixWinForms(this IServiceCollection services)
        {
            services.AddSingleton<IClipboardService, ClipBoardService>();
            services.AddSingleton<IFileDialogService, FileDialogService>();
            services.AddSingleton<IMessageDialogService, MessageDialogService>();
            services.AddSingleton<IWindowManager, WindowManager>();
            services.AddSingleton<IWindow, WindowsForm>();
        }

    }
}
