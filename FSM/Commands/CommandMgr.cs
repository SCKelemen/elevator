//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics.Tracing;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading;
//using System.Windows;


//namespace Commands
//{
//    class CommandMgr<Tparam, Tresult> where Tparam : new()
//    {
//        private List<ICommand<Tparam, Tresult>> stack = new List<ICommand<Tparam, Tresult>>();

//        public void Execute(ICommand<Tparam, Tresult> command)
//        {
//            command.ExecuteAsync(new Tparam());
//            stack.Add(command);
//        }
//    }

//    public class RollingStack<T>
//    {
//        private Node<T> _head;
//        private readonly int _maxSize;
//        private int _size;
//        public RollingStack(int maxSize)
//        {
//            _head = new Node<T>(default(T));
//            _maxSize = maxSize;
//        }

//        public int MaxSize => _maxSize;
//        public int Size => _size;

//        public T Peek()
//        {
//            T value = default(T);
//            if (_head.Next != null)
//            {
//                value = _head.Next.Value;
//            }
//            return value;
//        }

//        public T Pop()
//        {
//            Node<T> node = _head.Next;
           
//            // this is shit.
//            T value = node != null ? node.Value : default(T);
//            if (node != null)
//            {
//                _size--;
//                _head.Next = node.Next;
//            }

//            return value;

//        }

//        public bool Push(T value)
//        {
//            Node<T> node = new Node<T>(value);
//            node.Next = _head.Next;
//            _head.Next = node;

//            bool trimmed = _size >= MaxSize;
//            if (trimmed)
//            {
//                trim();
//            }
//            else
//            {
//                _size++;
//            }
//            return trimmed;
//        }

//        public int Count()
//        {
//            int counter = 0;
//            Node<T> node = _head;
//            while (node.Next != null)
//            {
//                counter++;
//                node = node.Next;
//            }
//            return counter;
//        }

//        private int trim()
//        {
//            int counter = 0;
//            Node<T> node = _head;
//            while (node != null)
//            {
//                if (counter == _maxSize)
//                {
//                    node.Next = null;
//                    break;
//                }
//                node = node.Next;
//                counter++;
//            }
//            _size = counter;
//            return counter;
//        }
//    }

//    public class Node<T>
//    {
//        private readonly T _value;

//        public Node(T value)
//        {
//            _value = value;
//        }

//        public T Value => _value;

//        public Node<T> Next;

//    }
//}
