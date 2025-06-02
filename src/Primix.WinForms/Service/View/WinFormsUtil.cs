using Primix.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primix.WinForms.Service.View
{
    internal static class WinFormsUtil
    {
        public static WindowResult ToWindowResult(DialogResult result)
        {
            switch (result)
            {
                case DialogResult.None: return WindowResult.None;
                case DialogResult.OK: return WindowResult.OK;
                case DialogResult.Cancel: return WindowResult.Cancel;
                case DialogResult.Abort: return WindowResult.Abort;
                case DialogResult.Retry: return WindowResult.Retry;
                case DialogResult.Ignore: return WindowResult.Ignore;
                case DialogResult.Yes: return WindowResult.Yes;
                case DialogResult.No: return WindowResult.No;
                default: return WindowResult.No;
            }
        }
    }
}
