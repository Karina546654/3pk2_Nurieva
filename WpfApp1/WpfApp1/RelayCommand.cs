using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    internal class RelayCommand: ICommand
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;

        public bool CanExecute(object? parameter)
        {
            return _canExecute.Invoke(parameter);
        }
        public void Execute(object? parameter)
        {
            _execute?.Invoke(parameter);
        }

        public event EventHandler? CanExecuteChanged
        {
           add
            {
                if (CanExecute != null)
                    CommandManager.RequerySuggested += value;

            }
            remove
            {
                if (CanExecute != null)
                { CommandManager.RequerySuggested -= value; }
            }
        }
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _canExecute = canExecute;
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        }
    }
}
