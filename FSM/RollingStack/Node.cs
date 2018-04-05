using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace RollingStack
{
    public class Node<T> : IEnumerable<T>
    {
        private readonly T _value;

        public Node(T value)
        {
            _value = value;
        }

        public T Value => _value;

        public Node<T> Next;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
        }
        public NodeEnumeration<T> GetEnumerator()
        {
            return new NodeEnumeration<T>(this); 
        }


    }

    public class NodeEnumeration<T> : IEnumerator<T>
    {
        private readonly Node<T> _head;
        private Node<T> _current;

        public NodeEnumeration(Node<T> head)
        {
            _head = head;
            _current = head;
        }
        public bool MoveNext()
        {
            _current = _current?.Next;

            return _current?.Next != null;
        }

        public void Reset()
        {
            _current = _head;
        }

        object IEnumerator.Current => Current;

        public T Current => _current.Value;

        public void Dispose()
        {
            
        }
    }
}
