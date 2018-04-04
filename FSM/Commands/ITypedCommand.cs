using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Commands
{
    public interface ITypedCommand<T1, T2>
    { 
        event EventHandler CanExecuteChanged;
        bool CanExecute(T1 parameter);
        Task<T2> Execute(T1 parameter);
    }

    class item
    {
        event EventHandler Requery
        {
            add { CommandMana}
        }
    }
}
