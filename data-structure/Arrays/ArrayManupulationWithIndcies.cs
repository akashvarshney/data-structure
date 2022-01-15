using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Arrays
{
    public class ArrayManupulationWithIndcies
    {
        public static int ArrayManupulation(int n, List<List<int>> queries)
        {
            int a = 0;
            int b = 1;
            int k = 2;
            
            int[] array = new int[n];
            foreach (var item in queries)
            {
                for (int i = 0; i < n; i++)
                {
                    if (item[a] - 1 <= i && item[b] - 1 >= i)
                        array[i] = array[i] + item[k];
                }   
            }
            return array.Max();
        }
    }
}
