using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;


namespace Commands
{
    class CommandMgr<Tparam, Tresult> where Tparam : new()
    {
        private List<ICommand<Tparam, Tresult>> stack = new List<ICommand<Tparam, Tresult>>();

        public void Execute(ICommand<Tparam, Tresult> command)
        {
            command.ExecuteAsync(new Tparam());
            stack.Add(command);
        }
    }

    public class RollingStack<T>
    {
        private Node<T> _head;
        private readonly int _maxSize;
        private int _size;
        public RollingStack(int maxSize)
        {
            _maxSize = maxSize;
        }

        public int MaxSize => _maxSize;
        public int Size => _size;

        public T Peek()
        {
            return _head.Value;
        }

        public T Pop()
        {

            if (_head.Next != null)
            {
                
            }
            _size--;

        }

        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = _head;
            if (_size >= MaxSize)
            {

            }
            else
            {
                _size++;
            }
        }

    }

    public class Node<T>
    {
        private readonly T _value;

        public Node(T value)
        {
            _value = value;
        }

        public T Value => _value;

        public Node<T> Next;

    }
}
