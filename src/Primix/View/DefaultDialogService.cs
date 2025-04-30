using System;

namespace Primix.View
{
    internal class DefaultDialogService : IDialogService
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
