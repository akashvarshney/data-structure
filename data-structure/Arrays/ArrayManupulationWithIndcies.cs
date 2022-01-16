using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Arrays
{
    public class ArrayManupulationWithIndcies
    {
        /// <summary>
        /// O(n^2)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
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
        /// <summary>
        /// With O(n)  using Prefix SUM Algo
        /// </summary>
        /// <param name="n"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public static long ArrayManupulatioBetter(int n, List<List<long>> queries)
        {

            int m = queries.Count;
            long[] output = new long[n + 2];
            for (int i = 0; i < queries.Count; i++)
            {
                long a = queries[i][0];
                long b = queries[i][1];
                long k = queries[i][2];
                output[a] = output[a] + k;
                output[b + 1] = output[b + 1] - k;
            }


            //Use Prefix sum algorithm
            long sum = 0;
            long max = long.MinValue;
            for (int i = 0; i < output.Length - 1; i++)
            {
                sum = sum + output[i];
                max = Math.Max(max, sum);
            }
            return max;

        }
    }
}
