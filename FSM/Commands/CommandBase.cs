//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;

//namespace Commands
//{
//    public abstract class CommandBase<Tparam, Tresult> : ICommand<Tparam, Tresult>
//    {
//        public abstract bool CanExecute(Tparam parameter);
//        public abstract Task<Tresult> ExecuteAsync(Tparam parameter);

//        public Task<Tresult> Execute(Tparam parameter)
//        {
//            return ExecuteAsync(parameter);
//        }

//        public event EventHandler CanExecuteChanged
//        {
//            add { CommandManager. .RequerySuggested += value;  }
//        }
//    }
//}
