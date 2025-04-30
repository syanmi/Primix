using Primix.Command;
using System.Windows.Forms;

namespace WindowsFormsSample.Command
{
    static public class CommandBinder
    {
        public static void Bind(this Button button, ICommand command)
        {
            // 1. Clickイベントで ICommand.Execute() を呼ぶ
            button.Click += (s, e) =>
            {
                if (command.CanExecute(null))
                    command.Execute(null);
            };

            // 2. CanExecuteChanged が発火されたら Enabled 状態を更新
            command.CanExecuteChanged += (s, e) =>
            {
                button.Enabled = command.CanExecute(null);
            };

            // 初期状態を反映
            button.Enabled = command.CanExecute(null);
        }
    }
}
