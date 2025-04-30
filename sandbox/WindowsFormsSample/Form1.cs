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
        public Form1()
        {
            InitializeComponent();

            _button1.Bind(ApplicationCommands.CommandA);
            _button2.Bind(ApplicationCommands.CommandB);
            _button3.Bind(ApplicationCommands.CommandC);

        }
    }
}
