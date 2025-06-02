namespace Primix.View
{
    public static class MessageDialogExtensions
    {
        public static WindowResult ShowMessage(this IMessageDialogService dialog, IWindow owner, string message, string caption = null, MessageDialogButton button = MessageDialogButton.OK)
            => dialog.Show(owner, message, caption, button, MessageDialogIcon.None);
        public static WindowResult ShowInformationMessage(this IMessageDialogService dialog, IWindow owner, string message, string caption = null, MessageDialogButton button = MessageDialogButton.OK)
            => dialog.Show(owner, message, caption, button, MessageDialogIcon.Information);
        public static WindowResult ShowWarningMessage(this IMessageDialogService dialog, IWindow owner, string message, string caption = null, MessageDialogButton button = MessageDialogButton.OK)
            => dialog.Show(owner, message, caption, button, MessageDialogIcon.Warning);
        public static WindowResult ShowErrorMessage(this IMessageDialogService dialog, IWindow owner, string message, string caption = null, MessageDialogButton button = MessageDialogButton.OK)
            => dialog.Show(owner, message, caption, button, MessageDialogIcon.Error);
        public static WindowResult ShowQuestionMessage(this IMessageDialogService dialog, IWindow owner, string message, string caption = null, MessageDialogButton button = MessageDialogButton.OK)
            => dialog.Show(owner, message, caption, button, MessageDialogIcon.Question);

        public static WindowResult Show(this IMessageDialogService dialog, string message, string caption, MessageDialogButton button, MessageDialogIcon icon)
        {
            return dialog.Show(null, message, caption, button, icon);
        }
        public static WindowResult ShowMessage(this IMessageDialogService dialog, string message, string caption = null, MessageDialogButton button = MessageDialogButton.OK)
            => dialog.Show(message, caption, button, MessageDialogIcon.None);
        public static WindowResult ShowInformationMessage(this IMessageDialogService dialog, string message, string caption = null, MessageDialogButton button = MessageDialogButton.OK)
            => dialog.Show(message, caption, button, MessageDialogIcon.Information);
        public static WindowResult ShowWarningMessage(this IMessageDialogService dialog, string message, string caption = null, MessageDialogButton button = MessageDialogButton.OK)
            => dialog.Show(message, caption, button, MessageDialogIcon.Warning);
        public static WindowResult ShowErrorMessage(this IMessageDialogService dialog, string message, string caption = null, MessageDialogButton button = MessageDialogButton.OK)
            => dialog.Show(message, caption, button, MessageDialogIcon.Error);
        public static WindowResult ShowQuestionMessage(this IMessageDialogService dialog, string message, string caption = null, MessageDialogButton button = MessageDialogButton.OK)
            => dialog.Show(message, caption, button, MessageDialogIcon.Question);
    }
}
