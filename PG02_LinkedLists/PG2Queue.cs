using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PG02_LinkedLists
{
    public class PG2Queue<T> 
    {


        public class Node
        {
            public Node(T t)
            {
                data = t;
                Next = null;
            }
            public T data;
            public Node Next;

            internal void Remove(Node first)
            {
                first.Remove(first);
            }


        }

        public int Count { get; private set; }
        private Node _head;
        private Node _tail;


        public void Enqueue(T data)
        {
            Node node = new Node(data);

            if (_tail == null)
            {
                _head = _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
            Count++;

        }
        public T Dequeue()
        {
            Node first = _head;

            T hold;

            if (_head != null)
            {
                hold = first.data;

                _head = _head.Next;

                Count--;

                if (_head == null) _tail = null;

                return hold;
            }
            else throw new InvalidOperationException();


        }

        public T Peek()
        {
            if (Count != 0)
            {
                return _head.data;
            }
            else throw new InvalidOperationException();

        }
        public void Reverse()
        {


            Node current = _head,  last = null, next;

            while (current != null)
            {
                next = current.Next;
                current.Next = last;
                last = current;
                current = next;

            }
            _head = last;

        }
    }
}
