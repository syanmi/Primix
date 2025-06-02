namespace Primix.View
{
    public interface IMessageDialogService
    {
        WindowResult Show(IWindow owner, string message, string caption, MessageDialogButton button, MessageDialogIcon icon);
    }
}
