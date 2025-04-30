using System;
using System.Collections.Generic;
using System.Linq;

namespace Primix.Command
{
    public class CompositeCommand : ICommand
    {
        private readonly List<ICommand> _commands = new List<ICommand> { };

        public event EventHandler CanExecuteChanged;

        public void Add(ICommand command) => _commands.Add(command);

        public bool CanExecute(object parameter) => _commands.All(c => c.CanExecute(parameter));

        public void Execute(object parameter)
        {
            foreach (var command in _commands)
            {
                if (command.CanExecute(parameter))
                    command.Execute(parameter);
            }
        }
    }
}
