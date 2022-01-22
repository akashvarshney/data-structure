using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Stack
{
    //
    public class NextGreaterElement
    {
        /// <summary>
        /// Given an array find the next greator element 
        /// for last index recheck the element from the array 
        /// if not found return -1 to that index
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> FindNextGreaterElement(List<int> list)
        {
            List<int> result = new List<int>();
            Stack<int> stack = new Stack<int>();
            for (int i = 2 * list.Count - 1; i >= 0; i--)
            {
                if (i > list.Count - 1)
                {
                    int tempi = i % list.Count;
                    if (stack.Count == 0)
                    {
                        stack.Push(list[list.Count - 1]);
                        result.Add(-1);
                    }
                    else
                    {
                        if (list[tempi] < stack.Peek())
                        {
                            result.Add(stack.Peek());
                        }
                        else if (list[tempi] > stack.Peek())
                        {
                            stack.Push(list[tempi]);
                            result.Add(-1);
                        }
                    }

                }
            }

            //result  
            result.Reverse();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (result[i] == -1 && list[i] < stack.Peek())
                {
                    result[i] = stack.Peek();
                    stack.Pop();
                }
            }

            return result;
        }
    }

}

