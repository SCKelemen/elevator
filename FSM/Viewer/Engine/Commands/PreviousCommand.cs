using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Engine.Commands
{
    class PreviousCommand : CommandBase
    {
        bool Execute(Context ctx)
        {
            ctx.Get("file");
            Console.WriteLine("Previous Command");
            return true;
        }
    }
}
