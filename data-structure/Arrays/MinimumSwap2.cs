using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Arrays
{
    public class MinimumSwap2
    {
        public static int minimumswaps(int[] list)
        {
            //1, 5, 3, 4, 2, 6
            int swaps = 0;
            for (int i = list.Length - 1; i >= 0; i--)
            {
                if (list[list.Length -1- i] != i + 1)
                {
                    swaps++;
                    swapwithcorrecttpostion(list, i, (list[i] - 1));

                }
            }
            return swaps;
        }
        private static void swapwithcorrecttpostion(int[] arry, int a, int b)
        {
            int temp = 0;
            temp = arry[a];
            arry[a] = arry[b];
            arry[b] = temp;
        }
    }
}
