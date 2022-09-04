using System.Threading.Tasks;
using System.Collections;
using System;
using System.Linq;

namespace Structs
{
    public class Node<T>
    {
        public Node(T value)
            => this.Value = value;

        public T Value;
        public Node<T> Next;
    }


    public class LinkedList<T> : IEnumerable<T>
    {
        Node<T> Head;
        Node<T> Tail;
        int Count;


        public bool Contains(T val)
        {
            Node<T> cur = Head;

            while(cur != null)
            {
                if (cur.Value.Equals(val))
                    return true;
                
                cur = cur?.Next;
            }

            return false;
        }

        public void Add(T val)
        {
            Node<T> newNode = new(val);

            if (Head == null)
                Head = newNode;

            else
            {
                Node<T> cur = Head;
                while(cur.Next != null)
                    cur = cur.Next;

                cur.Next = newNode;
            }
        }

        public void Remove(T val)
        {
            Node<T> prev = Head;
            Node<T> cur = null;

            while(prev?.Next != null)
            {
                cur = prev.Next;
            
                if (cur.Value.Equals(val))
                {
                    // switch to next (remove)
                    if (cur.Next != null)
                        prev.Next = cur.Next;


                    else 
                        prev.Next = null;

                    break;
                }
                
                prev = cur;                
            }
            
            Count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
            => ((IEnumerable)this).GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> cur = Head;

            while(cur != null)
            {
                yield return cur.Value;
                cur = cur.Next;
            }
        }
    }

}