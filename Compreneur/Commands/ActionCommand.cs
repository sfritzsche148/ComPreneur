﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Compreneur.Commands
{
    internal class ActionCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action _execute { get; set; }
        private Func<bool> _canExecute { get; set; }

        public ActionCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }
    }

    internal class ActionCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<T> _execute { get; set; }
        private Func<T, bool> _canExecute { get; set; }

        public bool CanExecute(object parameter)
        {

            return _canExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
