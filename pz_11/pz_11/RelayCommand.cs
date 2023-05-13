using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace pz_11
{
        class RelayCommand : ICommand
        {
            private readonly Predicate<object> _canExecute;
            private readonly Action<object> _execute;

            public bool CanExecute(object parameter)
            {
                return _canExecute.Invoke(parameter);
            }

            public void Execute(object parameter)
            {
                _execute?.Invoke(parameter);
            }

            public event EventHandler? CanExecuteChanged
            {
                add
                {
                    CommandManager.RequerySuggested += value;
                }
                remove
                {
                    CommandManager.RequerySuggested -= value;
                }
            }

            public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
            {
                _canExecute = canExecute;
                _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            }
        }
    }