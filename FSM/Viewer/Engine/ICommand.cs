using System;
using System.Collections.Generic;
using System.Text;
using Commands;

namespace Application.Engine
{
    public interface ICommand
    {
        bool CanExecute(Context ctx);

        bool Execute(Context ctx);
    }
}
