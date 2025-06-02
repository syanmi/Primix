using Primix.View;
using System.Linq;
using System.Windows.Forms;

namespace Primix.WinForms.Service.View
{
    class WindowsForm : IWindow
    {
        private Form _form;

        public string Name => _form.Name;
        public Form Form => _form;
        public IWindow Parent => _form.Owner != null ? new WindowsForm(_form.Owner) : null;
        public IWindow[] Children => Application.OpenForms.Cast<Form>()
            .Where(f => f.Owner == _form)
            .Select(f => new WindowsForm(f))
            .ToArray();
        public bool IsVisible => _form.Visible;

        public WindowsForm(Form form)
        {
            _form = form;
        }

        public void Activate() => _form.Activate();
        public void Minimize() => _form.WindowState = FormWindowState.Minimized;
        public void Maximize() => _form.WindowState = FormWindowState.Maximized;
        public void Show() => _form.Show();
        public WindowResult ShowDialog() => WinFormsUtil.ToWindowResult(_form.ShowDialog());
        public void Close() => _form.Close();
    }
}
