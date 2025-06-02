using Primix.Service;
using Primix.View;
using Primix.WinForms.Service.View;

namespace Primix
{
    public static class PrimixExtensions
    {
        public static void AddPrimixWinForms(this IServiceCollection services)
        {
            services.AddSingleton<IWindow, WindowsForm>();
            services.AddSingleton<IMessageDialogService, MessageDialogService>();
        }

    }
}
