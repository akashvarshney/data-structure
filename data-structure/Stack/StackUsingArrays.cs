using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Stack
{
    public class StackUsingArrays
    {
        public int[] array { get; set; }
        public int Top { get; set; }
        public int Bottom { get; set; }
        public int Length { get; set; }

        public StackUsingArrays(int size)
        {
            array = new int[size];
        }

        public void Push(int val)
        {
            if (Length == array.Length)
            {
                // Stack overflow may happen
            }
            else
            {
                array.Append(val);
                Length++;
            }
        }
        public int Pop()
        {
            if (Length == 0)
            {
                // Nothing to Pop 
                return -1;
            }
            else
            {
                return array[0]--;
            }
        }

        public int Peek()
        {
            return array[0];
        }
    }
}
