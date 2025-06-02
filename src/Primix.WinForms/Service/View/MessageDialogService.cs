using Primix.View;
using System.Windows.Forms;

namespace Primix.WinForms.Service.View
{
    class MessageDialogService : IMessageDialogService
    {
        public WindowResult Show(IWindow owner, string message, string caption, MessageDialogButton button, MessageDialogIcon icon)
        {
            var result = MessageBox.Show(message, caption, ToMessageBoxButtons(button), ToMessageBoxIcon(icon));
            return WinFormsUtil.ToWindowResult(result);
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
    }
}
