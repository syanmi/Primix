namespace Primix.View
{
    public interface IClipboardService
    {
        void SetText(string text);
        string GetText();
        bool ContainsText();
    }
}
