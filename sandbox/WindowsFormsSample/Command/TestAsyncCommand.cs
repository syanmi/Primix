using Primix.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsSample.Command
{
    public class TestAsyncCommand : AsyncCommandBase<object>
    {
        public TestAsyncCommand() : base(false, false)
        {
        }

        protected override bool InternalCanExecute(object parameter = null) => true;

        protected override async Task InternalExecuteAsync(object parameter, CancellationToken token, IProgress<double> progress)
        {
            await Task.Delay(1000); // ダミー非同期処理
            Console.WriteLine("データ読み込み完了");
        }
    }
}
