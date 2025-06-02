using Primix.View;
using Primix.WinForms.Service.View;
using System.Windows.Forms;

namespace Primix.WinForms
{
    public static class FormExtensions
    {
        public static IWindow ToWindow(this Form form)
        {
            return new WindowsForm(form);
        }
    }
}
