using System;
using System.Collections.Generic;
using System.Text;
using Commands;
using Application.Engine;
using Application.Engine.Commands;

namespace Application.Processor
{
    public class CommandProcessor
    {
        private bool _shouldProcess;
        public CommandProcessor(bool start)
        {
            if (start)
            {
                Start();
            }
        }

        public void Start()
        {
            _shouldProcess = true;
            CommandLoop();
        }

        public void Stop()
        {
            _shouldProcess = false;
        }
        private void CommandLoop()
        {
            while (_shouldProcess && KeyProcessor())
            {
                

            }
        }

        private bool KeyProcessor()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    CommandDispatcher.Dispatch(EngineCommands.Flag,
                        new Context());
                    break;
                case ConsoleKey.LeftArrow:
                    CommandDispatcher.Dispatch(EngineCommands.Flag,
                        new Context());
                    break;
                case ConsoleKey.RightArrow:
                    CommandDispatcher.Dispatch(EngineCommands.Flag,
                        new Context());
                    break;
                case ConsoleKey.Escape:
                    Stop();
                    CommandDispatcher.Dispatch(EngineCommands.Flag,
                        new Context());
                    return false;
                default:
                    break;
            }
            
            return true;

        }
    }
}
