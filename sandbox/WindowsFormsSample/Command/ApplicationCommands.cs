using Primix.Command;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsSample.Command
{
    static class ApplicationCommands
    {
        public static ICommand CommandA { get; } = new RelayCommand(_ => Console.WriteLine("CommandA executed."));
        public static ICommand CommandB { get; } = new RelayCommand(_ =>
        {
            Console.WriteLine("CommandB start.");
            Thread.Sleep(5000);
            Console.WriteLine("CommandB executed.");
        });

        public static IAsyncCommand CommandC { get; } = new AsyncCommand(async _ => 
            {
                await Task.Delay(5000);
                Console.WriteLine("CommandC executed.");
            });
    }
}
