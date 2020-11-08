using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace EnlaceDeDatos
{
    public class MyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly Action _action;
        private readonly Func<bool> _canExecute;

        public MyCommand(Action action) : this(action, () => true)
        {
            _action = action;
        }

        public MyCommand(Action action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute();
        }

        public void Execute(object parameter)
        {
            _action();
        }

        public void ReevaluateCanExecute()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
