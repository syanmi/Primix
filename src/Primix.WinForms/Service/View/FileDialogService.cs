using Primix.View;
using System.Windows.Forms;

namespace Primix.WinForms.Service.View
{
    class FileDialogService : IFileDialogService
    {
        public FileDialogResult ShowOpenFileDialog(IWindow owner, string title, string filter, string initialDirectory, string defaultFileName)
        {
            var dialog = new OpenFileDialog
            {
                Title = title,
                Filter = filter,
                InitialDirectory = initialDirectory,
                FileName = defaultFileName
            };

            var result = dialog.ShowDialog(owner as IWin32Window);
            return new FileDialogResult((result == DialogResult.OK), result == DialogResult.OK ? dialog.FileName : null);
        }

        public FileDialogResult ShowSaveFileDialog(IWindow owner, string title, string filter, string initialDirectory, string defaultFileName)
        {
            var dialog = new SaveFileDialog
            {
                Title = title,
                Filter = filter,
                InitialDirectory = initialDirectory,
                FileName = defaultFileName
            };

            var result = dialog.ShowDialog(owner as IWin32Window);
            return new FileDialogResult((result == DialogResult.OK), result == DialogResult.OK ? dialog.FileName : null);
        }
    }
}
