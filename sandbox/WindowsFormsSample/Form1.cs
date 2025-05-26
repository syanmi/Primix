using Primix.Disposable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsSample.Command;

namespace WindowsFormsSample
{
    public partial class Form1 : Form
    {

        public static IDisposable Hook<T>(T field, T handler) where T : Delegate
        {
            field = (T)Delegate.Combine(field, handler);
            return Disposables.Action(() => field = (T)Delegate.Remove(field, handler));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click2(object sender, EventArgs e)
        {
            Console.WriteLine("button1_Click start.");
            Console.WriteLine("button1_Click finished.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var dialog = new TestDialog(async (token) =>
            {
                int counter = 0;
                while (true)
                {
                    token.ThrowIfCancellationRequested();
                    await Task.Delay(100, token);
                    Console.WriteLine($"{counter}");
                    counter++;
                }
            }))
            {
                dialog.ShowDialog();
            }
        }
    }
}
