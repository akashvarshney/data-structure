using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.DoublyLinkedList
{
    public class DoublyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public int Length { get; set; }

        public void AppendLast(int val)
        {
            if (Head == null)
            {
                Head = new Node(val);
                Tail = Head;
            }
            else
            {
                Node node = new Node(val);
                Tail.Next = node;
                Tail.Previous = Tail;
                Tail = node;
            }

            Length++;
        }

        public void AppendFirst(int val)
        {
            if (Head == null)
            {
                Head = new Node(val);
                Tail = Head;
            }
            else
            {
                Node first = new Node(val);
                Head.Previous = first;
                first.Next = Head;
                Head = first;
            }
            Length++;
        }

        public void InsertAt(int index, int val)
        {
            if (index == 0)
            {
                AppendFirst(val);
            }
            else if (index == Length - 1)
            {
                AppendLast(val);
            }
            else
            {
                Node vtx = new Node(val);
                Node pre = Head;

                Node aft = pre.Next;
                for (int i = 0; i < index - 1; i++)
                {
                    pre = pre.Next;
                }
                vtx.Next = aft;
                aft.Previous = vtx;
                vtx.Previous = pre;
                pre.Next = vtx;

                Length++;
            }
        }

    }

    public class Node
    {
        public Node Previous { get; set; }
        public Node Next { get; set; }
        public int Value { get; set; }


        public Node(int val)
        {
            this.Value = val;
            this.Next = null;
            this.Previous = null;
        }
    }    
}
