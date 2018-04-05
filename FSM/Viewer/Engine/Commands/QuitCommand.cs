using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Engine.Commands
{
    class QuitCommand : CommandBase
    {
        bool Execute(Context ctx)
        {
            ctx.Get("file");
            Console.WriteLine("Quit Command");
            return true;
        }
    }
}
