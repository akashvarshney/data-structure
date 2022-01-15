using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Arrays
{
    // There is a collection of input strings and a collection of query strings.For each query string, determine how
    //many times it occurs in the list of input strings.Return an array of the results.

    //Example
    //strings = ['ab, ab,abc']
    //guerres['ab, abc, bc']

    //There are 2 instances of 'ab, l of abc' and 0 of 'bc. For each query, add an element to the return array,
    //results = |2,1,0]

    public class SparseArray
    {
        public static List<int> MatchingString(List<string> stringlist, List<string> queriesList)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < queriesList.Count; i++)
            {
                int temp = 0;
                for (int j = 0; j < stringlist.Count; j++)
                {
                    if (stringlist[j] == queriesList[i])
                    {
                        temp++;
                    }
                }
                result.Add(temp);
            }
            return result;
        }
    }
}
