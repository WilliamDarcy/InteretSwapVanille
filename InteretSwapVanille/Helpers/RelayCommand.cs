using System;
using System.Windows.Input;

namespace InteretSwapVanille.Helpers
{
    public class RelayCommand : ICommand
    {
        private readonly Action<Object> _execute;
        private readonly Predicate<Object> _canExecute;

        public RelayCommand(Action<Object> action): this(action, null)
        {
        }

        public RelayCommand(Action<Object> action,Predicate<Object> predicate)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));

            _execute = action;
            _canExecute = predicate;
        }


        public bool CanExecute(object parameter)
        {
            if (_canExecute != null)
                return _canExecute(parameter);
            return true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
        }

    }
}