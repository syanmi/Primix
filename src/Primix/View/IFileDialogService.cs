namespace Primix.View
{
    public interface IFileDialogService
    {
        FileDialogResult ShowOpenFileDialog(
            IWindow owner,
            string title = "",
            string filter = "All files (*.*)|*.*",
            string initialDirectory = "",
            string defaultFileName = "");

        FileDialogResult ShowSaveFileDialog(
            IWindow owner,
            string title = "",
            string filter = "All files (*.*)|*.*",
            string initialDirectory = "",
            string defaultFileName = "");
    }
}
