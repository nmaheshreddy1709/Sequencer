﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SequencerProj.Commands
{
    public class ViewModelCommand : ICommand
    {
        private readonly Action<object> _action;
        private ICommand moiSelectionChanged;

        public ViewModelCommand(Action<object> action)
        {
            _action = action;
        }

        public ViewModelCommand(ICommand moiSelectionChanged)
        {
            this.moiSelectionChanged = moiSelectionChanged;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action.Invoke(parameter);
        }
    }
}
