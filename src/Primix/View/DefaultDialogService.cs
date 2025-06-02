using System;

namespace Primix.View
{
    internal class DefaultDialogService : IMessageDialogService
    {
        public WindowResult Show(IWindow owner, string message, string caption, MessageDialogButton button, MessageDialogIcon icon)
        {
            Console.WriteLine(message);
            return WindowResult.None;
        }
    }
}
