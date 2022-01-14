using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Queue
{
    public class Node
    {
        public Node Next { get; set; }
        public int Value { get; set; }
        public Node(int val)
        {
            Value = val;
        }
    }
    // First              Last
    // 23-->24-->12-->4-->88-->null
    public class QueueUsingLL
    {
        public Node First { get; set; }
        public Node Last { get; set; }
        public int Length { get; set; }

        public QueueUsingLL()
        {
            First = null;
            Last = null;
            Length = 0;
        }

        public int Peek()
        {
            return First.Value;

        }
        public int EnQueue(int val)
        {
            Node node = new Node(val);

            if (Length == 0)
            {
                First = node;
                Last = First;
            }
            else
            {
                Node temp = Last;
                Last = node;
                Last.Next = temp;
            }
            Length++;
            return First.Value;
        }

        public void Dequeue()
        {
            if (Length != 0)
            {
                First = First.Next;
            }
            Length--;
        }

    }
}
