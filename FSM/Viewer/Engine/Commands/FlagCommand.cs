using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Engine.Commands
{
    class FlagCommand : CommandBase
    {
        bool Execute(Context ctx)
        {
             ctx.Get("file");
            Console.WriteLine("Flag Command");
            return true;
        }
    }
}
