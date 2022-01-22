using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Arrays
{
    public class LeftRotation
    {
        public static List<int> Rotate(List<int> a, int b)
        {
            //[1,2,3, 4,5]-->[2,3,4,5, 1]--> |3,4,5, 1,2]--> [4,5, 1,2,3]--> [5, 1,2,3, 4]
            var output = new int[a.Count];

            var input = a.ToArray();
            int afterindex = 0;
            for (int i = 0; i < a.Count; i++)
            {
               
                if (i < b)
                {
                    output[a.Count - 1 - i] = input[b - 1 - i];
                }
                else
                {
                    output[afterindex] = input[i];
                    afterindex++;
                }

            }
            return output.ToList();

        }
    }
}
