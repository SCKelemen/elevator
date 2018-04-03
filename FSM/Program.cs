using System;
using System.Collections.Generic;
using StateMachine;

namespace FSM
{
    public class ElevatorState : IState
    {
        private readonly string _state;

        public ElevatorState(string state)
        {
            _state = state;
        }

        public override string ToString()
        {
            return _state;
        }
    }
    static class ElevatorStates
    {
        public static readonly IState MaintenanceState = new ElevatorState("Maintenance");
        public static readonly IState MoveUpState = new ElevatorState("Move Up");
        public static readonly IState MoveDownState = new ElevatorState("Move Down");
        public static readonly IState StandState = new ElevatorState("Stand");
    }
    public class ElevatorCommand : ICommand
    {
        private readonly string _command;

        public ElevatorCommand(string command)
        {
            _command = command;
        }

        public override string ToString()
        {
            return _command;
        }
    }

    public class ElevatorCommands
    {
        public static readonly ICommand Call1 = new ElevatorCommand("Call First Floor");
    }

    public class Elevator
    {
        private ElevatorState _state;
        private readonly string _identity;
        public Elevator(string identifier, ElevatorState state)
        {
            _state = state;
            Identity = identifier;
        }

        public ElevatorState Status => _state;
        public readonly string Identity;
    }
    public class ElevatorGroup : List<Elevator>
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            ElevatorShaft shaft = new ElevatorShaft(12);
            Floor floor = shaft.first;

            foreach (Floor f in shaft.floors)
            {
                Console.WriteLine($"Floor: {f.Number}\tUp: {f.Up?.Number}\tDown: {f.Down?.Number}");
            }
            //
            for (int i = 1; i <= shaft.height; i++)
            {
                Console.WriteLine("At Floor: {0}", floor.Number);
                floor = floor.Up;
            }
            Console.WriteLine("Finished.");
            Console.ReadKey();
        }
    }
}
