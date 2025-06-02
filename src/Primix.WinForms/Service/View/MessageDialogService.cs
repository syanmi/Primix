using Primix.View;
using System.Windows.Forms;

namespace Primix.WinForms.Service.View
{
    class MessageDialogService : IMessageDialogService
    {
        public WindowResult Show(IWindow owner, string message, string caption, MessageDialogButton button, MessageDialogIcon icon)
        {
            var result = MessageBox.Show(message, caption, ToMessageBoxButtons(button), ToMessageBoxIcon(icon));
            return ToWindowResult(result);
        }

        private MessageBoxButtons ToMessageBoxButtons(MessageDialogButton button)
        {
            switch (button)
            {
                case MessageDialogButton.OK: return MessageBoxButtons.OK;
                case MessageDialogButton.OKCancel:return MessageBoxButtons.OKCancel;
                case MessageDialogButton.YesNo:return MessageBoxButtons.YesNo;
                case MessageDialogButton.YesNoCancel:return MessageBoxButtons.YesNoCancel;
                default:return MessageBoxButtons.OK;
            }
        }

        private MessageBoxIcon ToMessageBoxIcon(MessageDialogIcon icon)
        {
            switch (icon)
            {
                case MessageDialogIcon.None:return MessageBoxIcon.None;
                case MessageDialogIcon.Information:return MessageBoxIcon.Information;
                case MessageDialogIcon.Warning:return MessageBoxIcon.Warning;
                case MessageDialogIcon.Error:return MessageBoxIcon.Error;
                case MessageDialogIcon.Question:return MessageBoxIcon.Question;
                default:return MessageBoxIcon.None;
            }
        }

        private WindowResult ToWindowResult(DialogResult result)
        {
            switch (result)
            {
                case DialogResult.None: return WindowResult.None;
                case DialogResult.OK:return WindowResult.OK;
                case DialogResult.Cancel:return WindowResult.Cancel;
                case DialogResult.Abort:return WindowResult.Abort;
                case DialogResult.Retry:return WindowResult.Retry;
                case DialogResult.Ignore:return WindowResult.Ignore;
                case DialogResult.Yes:return WindowResult.Yes;
                case DialogResult.No:return WindowResult.No;
                default:return WindowResult.No;
            }
        }
    }
}
