using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Stack
{
    public class Node
    {
        public Node(int val)
        {
            Value = val;
        }
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    public class StackUsingLL
    {
        public Node Top { get; set; }
        public Node Bottom { get; set; }
        public int Length { get; set; }
        public StackUsingLL()
        {
            Top = null;
            Bottom = null;
            Length = 0;
        }

        public int Peek()
        {
            return Top.Value;
        }
        public int Push(int val)
        {
            if (Length == 0)
            {
                Top = new Node(val);
                Bottom = Top;
            }
            else
            {
                Node node = new Node(val);
                node.Next = Top;
                Top = node;

            }
            Length++;
            return Top.Value;
        }
        public int Pop()
        {
            if (Length == 0)
            {
                return -1; // Stack is empty
            }
            else if (Length == 1)
            {
                Top = null;
                Bottom = Top;
                Length--;
                return -1;

            }
            else if (Length == 2)
            {
                Top = Top.Next;
                Bottom = Top;
            }
            else
            {
                Top = Top.Next;

            }
            Length--;
            return Top.Value;
        }

    }
}
