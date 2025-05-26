using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSample
{
    public partial class TestDialog : Form
    {
        private CancellationTokenSource _source;
        private Func<CancellationToken, Task> _action;

        public TestDialog()
        {
            InitializeComponent();
            _source = new CancellationTokenSource();
        }

        public TestDialog(Func<CancellationToken, Task> action) : this()
        {
            _action = action;
        }

        private void TestDialog_Load(object sender, EventArgs e)
        {

        }

        private void _buttonCancel_Click(object sender, EventArgs e)
        {
            _source.Cancel();
        }

        private void TestDialog_Shown(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await _action(_source.Token);
            }).ContinueWith(OnCompleted, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void OnCompleted(Task t)
        {
            Close();
        }
    }
}
