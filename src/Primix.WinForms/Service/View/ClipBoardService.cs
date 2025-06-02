using Primix.View;

namespace Primix.WinForms.Service.View
{
    class ClipBoardService : IClipboardService
    {
        public void SetText(string text)
        {
            if (string.IsNullOrEmpty(text)) return;
            System.Windows.Forms.Clipboard.SetText(text);
        }

        public string GetText()
        {
            return System.Windows.Forms.Clipboard.ContainsText()
                ? System.Windows.Forms.Clipboard.GetText()
                : null;
        }

        public bool ContainsText()
        {
            return System.Windows.Forms.Clipboard.ContainsText();
        }
    }
}
