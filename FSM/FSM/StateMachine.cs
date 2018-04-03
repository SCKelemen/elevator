using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace StateMachine
{

    public interface IState
    {
        string ToString();

    }

    public interface ICommand
    {
        string ToString();
    }

    public class StateTransition<T1, T2> 
        where T1: IState
        where T2: ICommand
    {
        private readonly T1 _state;
        private readonly T2 _command;

        public StateTransition(T1 state, T2 command)
        {
            _state = state;
            _command = command;
        }

        public override int GetHashCode()
        {
            return (31 * _state.GetHashCode()) + (31 * _command.GetHashCode()) + 17;
        }

        public override bool Equals(object obj)
        {
            StateTransition<T1, T2> transition = obj as StateTransition<T1, T2>;
            return transition != null && _state.Equals(transition._state) && _command.Equals(transition._command);
        }
    }

    public class StateMachine<T1, T2> 
        where T1: IState
        where T2: ICommand
    {
        private T1 _state;
        private Dictionary<StateTransition<T1,T2>, T1> _transitions;

        public StateMachine(T1 initialState, Dictionary<StateTransition<T1, T2>, T1> stateTransitions)
        {
            _state = initialState;
            _transitions = stateTransitions;
        }

        public T1 GetNext(T2 command)
        {
            StateTransition<T1, T2> transition = new StateTransition<T1, T2>(_state, command);
            T1 nextState;
            if (!_transitions.TryGetValue(transition, out nextState))
            {
                throw new Exception($"Invalid transition: {_state} -> {command}");
            }
            return nextState;
        }

        public T1 MoveNext(T2 command)
        {
            _state = GetNext(command);
            return _state;
        }

    }
}
