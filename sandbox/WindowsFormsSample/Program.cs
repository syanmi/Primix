using Primix.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Primix;
using Primix.Service;
using Primix.Message;
using Primix.Data;
using Primix.Config;

namespace WindowsFormsSample
{

    public class SettingA
    {
        public string Name { get; set; } = "SettingA";
        public int Value { get; set; } = 100;
    }

    public class SettingB
    {
        public string Name { get; set; } = "SettingB";
        public int Value { get; set; } = 200;
    }


    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        internal class MessageClass
        {
            public string Message { get; set; }

            public MessageClass()
            {
            }

            public MessageClass(string data)
            {
                Message = "init message";
            }
        }


    }






}
