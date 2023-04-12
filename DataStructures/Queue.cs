using System;
namespace DataStructures
{
    public class Queue
    {
        public Node? start = null;
        public Node? end = null;
        public int Size = 0;

        public void Enqueue(int value)
        {
            Node n = new Node(value);

            if (start == null)
            {
                start = end = n;
                Size++;
            }
            else if (end != null)
            {
                Size++;
                end.next = n;
                end = n;
            }
        }

        public int Dequeue()
        {
            int value = 0;
            if (start != null)
            {
                value = start.value;
                start = start.next;

            }

            return value;
        }

        public void ShowQueue()
        {

        }
    }
}

