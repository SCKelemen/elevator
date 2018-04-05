using System;
using System.Collections.Generic;
using System.Text;
using RollingStack;

namespace FSM.RollingStack
{
    public class DoubleNode<T>
    {
        private readonly T _value;

        public DoubleNode(T value)
        {
            _value = value;
        }

        public T Value => _value;

        public DoubleNode<T> Next;
        public DoubleNode<T> Previous;
    }
}
