namespace Primix.View
{
    public class FileDialogResult
    {
        public bool IsAccepted { get; }
        public string FilePath { get; }

        public FileDialogResult(bool isAccepted, string filePath)
        {
            IsAccepted = isAccepted;
            FilePath = filePath;
        }
    }
}
