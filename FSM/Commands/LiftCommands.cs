using System;
using System.Collections.Generic;
using System.Text;

namespace FSM.Commands
{
    public class CallUpCommand : ICommand<string, string>
    {
        public event EventHandler CanExecuteChange += ValueTuple;
        public bool CanExecute(string parameter)
        {
            return false;
        }

        public string Execute(string parameter)
        {
            return parameter;
        }
    }
}
