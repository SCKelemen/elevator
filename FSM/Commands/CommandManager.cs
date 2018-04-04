using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Commands
{
    public static class CommandManager
    {
        private static List<Action> _raiseCanExecuteChangedActions = new List<Action>();

        public static void AddRaiseCanExecuteChangedAction(ref Action raiseCanExecuteChangedAction)
        {
            _raiseCanExecuteChangedActions.Add(raiseCanExecuteChangedAction);
        }

        public static void RemoveRaiseCanExecuteChangedAction(Action raiseCanExecuteChangedAction)
        {
            _raiseCanExecuteChangedActions.Remove(raiseCanExecuteChangedAction);
        }

        public static void AssignOnPropertyChanged(ref PropertyChangedEventHandler propertyEventHandler)
        {
            propertyEventHandler += OnPropertyChanged;
        }

        private static void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // this if clause is to prevent an infinity loop
            if (e.PropertyName != "CanExecute")
            {
                RefreshCommandStates();
            }
        }

        public static void RefreshCommandStates()
        {
            foreach (Action action in _raiseCanExecuteChangedActions)
            {
                action?.Invoke();
            }
        }
    }
}
