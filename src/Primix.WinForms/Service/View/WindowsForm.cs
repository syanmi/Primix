using Primix.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primix.WinForms.Service.View
{
    class WindowsForm : IWindow
    {
        private Form _form;

        public string Name => _form.Text;

        public IWindow Parent => throw new NotImplementedException();

        public IWindow[] Children => throw new NotImplementedException();


        public WindowsForm(Form form)
        {
            _form = form;
        }

        public void Close() => _form.Close();

        public void Maximize()
        {
            
        }

        public void Minimize()
        {
            throw new NotImplementedException();
        }
    }
}
