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


            var configfile = XDocumentDataSource.Load(@"C:\Users\Satoshi\Desktop\App\t\sandbox\WindowsFormsSample\bin\Debug\test.txt");
              
            var services = new SimpleServiceCollection();
            services.AddPrimix();
            services.Configure<SettingA>(configfile);
            services.Configure<SettingB>(configfile);

            var provider = services.BuildServiceProvider();


            var paramA = provider.GetService<IConfig<SettingA>>();
            Console.WriteLine($"SettingA.Name = {paramA.Value.Name}");
            Console.WriteLine($"SettingA.Value = {paramA.Value.Value}");
            paramA.Value.Value++;
            paramA.Save();

            var paramB = provider.GetService<IConfig<SettingB>>();
            Console.WriteLine($"SettingB.Name = {paramB.Value.Name}");
            Console.WriteLine($"SettingB.Value = {paramB.Value.Value}");
            paramB.Value.Value--;
            paramB.Save();

            //var data = provider.GetService<ISharedData<MessageClass>>();
            //var dispose = data.Subscribe((updated) => Console.WriteLine("onnext" + updated.Message));

            //var message = data.Value.Message;
            //Console.WriteLine("message");

            //var editor = data.GetEditor();
            //editor.Value.Message = "updated message";
            //editor.Commit();

            //Console.WriteLine($"message {data.Value.Message}");



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
