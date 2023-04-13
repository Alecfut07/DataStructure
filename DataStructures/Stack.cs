using System;
namespace DataStructures
{
	public class Stack
	{
        public Node? Top
        {
            get { return _top; }
        }
        private Node? _top = null;

        public int Size
        {
            get { return _size; }
        }
        private int _size = 0;

        public Stack()
        {
            _top = null;
            _size = 0;
        }

        public Stack(int value)
        {
            Push(value);
        }

        public void Push(int value)
        {
            Node n = new Node(value);

            if (_top == null)
            {
                _top = n;
            }
            else
            {
                n.Next = _top;
                _top = n;
            }
            _size++;
        }

        public int Pop()
        {
            int value = 0;
            if (_top != null)
            {
                value = _top.Value;
                _top = _top.Next;
            }

            return value;
        }

        public void Clear()
        {
            _top = null;
            _size = 0;
        }

        public bool Contains(int value)
        {
            Node temp = _top;
            while (temp != null)
            {
                if (temp.Value == value)
                {
                    return true;
                }
                temp = temp.Next;
            }

            return false;
        }

        public int Count()
        {
            return _size;
        }

        public int Peek()
        {
            if (_top == null)
            {
                return 0;
            }

            int value = _top.Value;
            return value;
        }

        public int[] ToArray()
        {
            int[] array = new int[_size];
            Node temp = _top;

            int i = 0;
            while (temp != null && i < array.Length)
            {
                array[i] = temp.Value;
                temp = temp.Next;
                i++;
            }

            return array;
        }
    }
}

