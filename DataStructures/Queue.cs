using System;
namespace DataStructures
{
    public class Queue
    {
        public Node? Start
        {
            get { return _start; }
        }
        private Node? _start = null;

        public Node? End
        {
            get { return _end; }
        }
        private Node? _end = null;

        public int Size
        {
            get { return _size; }
        }
        private int _size = 0;

        public Queue()
        {
            _start = _end = null;
            _size = 0;
        }

        public Queue(int value)
        {
            _start = _end = null;
            _size = value;
        }

        public void Enqueue(int value)
        {
            Node n = new Node(value);

            if (_start == null)
            {
                _start = _end = n;
            }
            else if (_end != null)
            {
                _end.Next = n;
                _end = n;
            }
            _size++;
        }

        public int Dequeue()
        {
            int value = 0;
            if (_start != null)
            {
                value = _start.Value;
                _start = _start.Next;
            }

            return value;
        }

        public void Clear()
        {
            _start = _end = null;
            _size = 0;
        }

        public bool Contains(int value)
        {
            Node n = new Node(value);
            if (_start != null)
            {
                if (_start.Value == value)
                {
                    return true;
                }
                else
                {

                }
            }
            return false;
        }

        public int Peek()
        {
            if (_start == null)
            {
                return 0;
            }

            int value = _start.Value;
            return value;
        }
    }
}

