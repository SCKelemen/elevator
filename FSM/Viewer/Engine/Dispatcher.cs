using System;
using System.Collections.Generic;
using System.Text;
using Application.Engine.Commands;

namespace Application.Engine
{
    public class CommandDispatcher
    {
        public static bool Dispatch(EngineCommands command, Context ctx)
        {
            switch (command)
            {
                case EngineCommands.Next:
                    return new NextCommand().Execute(ctx);
                case EngineCommands.Previous:
                    return new PreviousCommand().Execute(ctx);
                case EngineCommands.Flag:
                    return new FlagCommand().Execute(ctx);
                case EngineCommands.Quit:
                    return new QuitCommand().Execute(ctx);
                default:
                    return false;
            }
        }
    }
}
