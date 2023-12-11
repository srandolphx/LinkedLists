
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG02_LinkedLists
{
    public class PG2STACK<T>
    {
        //Node<char> c1 = new Node<char>() { };
        //Node<char> c2 = new Node<char>() { };
        

        public class Node
        {
             public Node (T t)
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

            internal Node Add(Node tail)
            {
                return tail.Add(tail);
            }
        }


        private Node _head;


        public int Count { get; private set; }

        public void Push(T data)
        {
            Node c1 = new Node(data); 

            
            c1.Next = _head;

            _head = c1;

            Count++;

        }

        public T Pop()
        {
            T hold;

            Node remove = _head;

           
           if (remove != null)
            {
                hold = _head.data;

                _head = _head.Next;

               
                Count--;
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
          

            Node last = null, current = _head, next;

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
