using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace project.Helpers
{
    public class RelayCommand : ICommand
    {
        public Action<object> execute;
        public Func<object, bool> canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            // canExecute default value is null

            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged 
        {
            // calling when conditions of can execute or not are changing

            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter); // if canExecute is not null do canExecute
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
