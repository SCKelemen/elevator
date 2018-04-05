using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Engine
{
    public abstract class CommandBase : ICommand
    {
        public virtual bool CanExecute(Context ctx)
        {
            return true;
        }

        public virtual bool Execute(Context ctx)
        {
            return true;
        }


    }
}
