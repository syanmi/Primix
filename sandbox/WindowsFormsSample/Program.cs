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

namespace WindowsFormsSample
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {

            var services = new SimpleServiceCollection();
            services.AddPrimix();

            var provider = services.BuildServiceProvider();

            var publisher = provider.GetService<IMessagePublisher<MessageClass>>();
            var subscriber = provider.GetService<IMessageSubscriber<MessageClass>>();

            subscriber.Subscribe((message) => Console.WriteLine(message.Message));

            publisher.Publish(new MessageClass("hello1"));
            publisher.Publish(new MessageClass("hello2"));
            publisher.Publish(new MessageClass("hello3"));


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        internal class MessageClass
        {
            public string Message { get; set; }
            public MessageClass(string message)
            {
                Message = message;
            }
        }


    }






}
