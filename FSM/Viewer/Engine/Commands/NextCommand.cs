using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Engine.Commands
{
    class NextCommand : CommandBase
    {
        bool Execute(Context ctx)
        {
            ctx.Get("file");
            Console.WriteLine("Next Command");
            return true;
        }
    }
}
