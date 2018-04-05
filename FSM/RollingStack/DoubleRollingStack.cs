using System;
using System.Collections.Generic;
using System.Text;

namespace FSM.RollingStack
{
    public class DoubleRollingStack<T>
    {
        private DoubleNode<T> _head;
        private DoubleNode<T> _tail;
        private readonly int _maxSize;
        private int _size;
        public DoubleRollingStack(int maxSize)
        {
            _head = new DoubleNode<T>(default(T));
            _tail = _head;
            _head.Next = _tail;
            _tail.Previous = _head;
            _maxSize = maxSize;
        }

        public int MaxSize => _maxSize;
        public int Size => _size;

        public T Peek()
        {
            T value = default(T);
            if (_head.Next != null)
            {
                value = _head.Next.Value;
            }
            return value;
        }

        public T Pop()
        {
            DoubleNode<T> node = _head.Next;

            // this is shit.
            T value = node != null ? node.Value : default(T);
            if (node != null)
            {
                _size--;
                _head.Next = node.Next;
            }

            return value;

        }

        public bool Push(T value)
        {
            DoubleNode<T> node = new DoubleNode<T>(value);
            node.Next = _head.Next;
            _head.Next = node;

            bool trimmed = _size >= MaxSize;
            if (trimmed)
            {
                trim();
            }
            else
            {
                _size++;
            }
            return trimmed;
        }

        public int Count()
        {
            int counter = 0;
            DoubleNode<T> node = _head.Next;
            while (node != null)
            {
                counter++;
                node = node.Next;
            }
            return counter;
        }

        private int trim()
        {
            int counter = 0;
            DoubleNode<T> node = _head;
            while (node != null)
            {
                if (counter == _maxSize)
                {
                    node.Next = null;
                    break;
                }
                node = node.Next;
                counter++;
            }
            _size = counter;
            return counter;
        }
    }
}
