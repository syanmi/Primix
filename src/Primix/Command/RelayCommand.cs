using System;

namespace Primix.Command
{
    public class RelayCommand : RelayCommand<object>, ICommand
    {
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null) : base(execute, canExecute)
        {
        }
    }
}
