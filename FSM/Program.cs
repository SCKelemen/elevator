using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
        public static readonly ElevatorState MaintenanceState = new ElevatorState("Maintenance");
        public static readonly ElevatorState MoveUpState = new ElevatorState("Move Up");
        public static readonly ElevatorState MoveDownState = new ElevatorState("Move Down");
        public static readonly ElevatorState StandState = new ElevatorState("Stand");
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
        private readonly ElevatorShaft _shaft;
        public Elevator(string identifier, ElevatorState state, ElevatorShaft shaft)
        {
            _state = state;
            Identity = identifier;
            _shaft = shaft;
        }


        public ElevatorState Status => _state;
        public readonly string Identity;
    }
    public class ElevatorGroup
    {
        private List<Elevator> _elevators;

        public ElevatorGroup(int count, int height)
        {
            _elevators = new List<Elevator>();
            while (count > 0)
            {
                _elevators.Add(new Elevator($"Elevator {count}", ElevatorStates.StandState, new ElevatorShaft(height)));
                count--;
            }
        }

        public Elevator this[int key]
        {
            get { return _elevators[key]; }
            set { _elevators[key] = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ElevatorGroup group = new ElevatorGroup(3, 12);
            

            Console.WriteLine("Finished.");
            Console.ReadKey();
        }
    }
}
