using Primix.View;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Primix.WinForms.Service.View
{
    class WindowManager : IWindowManager
    {
        public IReadOnlyList<IWindow> GetOpenWindows()
        {
            return Application.OpenForms.Cast<Form>().Select(x => new WindowsForm(x)).ToList();
        }

        public IWindow GetActiveWindow()
        {
            return new WindowsForm(Form.ActiveForm);
        }
    }
}
