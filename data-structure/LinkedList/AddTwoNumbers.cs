using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.LinkedList
{
    public class AddTwoNumbers
    {
        public static LinkedList<int> Add(LinkedList<int> a, LinkedList<int> b)
        {
            // input : (2-->4-->3) + (5-->6-->4)
            //342+ 465 = 807
            // output : (7-->0-->8)
            LinkedList<int> result = new LinkedList<int>();
            // read the value for first linked list in ineger

            int haasil_laga = 0;
            for (int i = 0; i < a.Count; i++)
            {
                int x = a.First.Value + b.First.Value;

                if (x > 9)
                {
                    haasil_laga = 1;
                    result.AddFirst(x - 10);
                }
                else if (haasil_laga != 0)
                {
                    result.AddLast(x + 1);
                    haasil_laga = 0;
                }
                else
                {
                    // add to new linked list
                    result.AddLast(x);
                }
                a.RemoveFirst();
                b.RemoveFirst();

            }

            return result;
        }
    }
}
