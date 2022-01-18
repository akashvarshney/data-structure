using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Stack
{
    public class GameOfTwoStack
    {
        /// <summary>
        /// Greedy Algo . Does not work :( 
        /// </summary>
        /// <param name="maxSum"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int twoStack(int maxSum, List<int> a, List<int> b)
        {
            int result = 0;
            //push list to stacks 

            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            for (int i = a.Count - 1; i >= 0; i--)
            {
                stack1.Push(a[i]);
            }
            for (int i = b.Count - 1; i >= 0; i--)
            {
                stack2.Push(b[i]);
            }

            int currentSum = maxSum;
            int totalpick = 0;
            while (currentSum > -1)
            {
                // pick the lowest peek value of stack
                if (stack1.Peek() > stack2.Peek())
                {
                    currentSum = currentSum - stack2.Peek();
                    if (currentSum >= 0)
                    {
                        stack2.Pop();
                        totalpick++;
                    }
                }
                else
                {
                    currentSum = currentSum - stack1.Peek();
                    if (currentSum >= 0)
                    {
                        stack1.Pop();
                        totalpick++;
                    }
                }
            }
            result = totalpick;
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxSum"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int TwoStackOtherways(int maxSum, List<int> a, List<int> b)
        {
            int result = 0; int totalsum = 0; int stack1pick = 0; int stack2pick = 0;

            //push list to stacks 

            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            for (int i = a.Count - 1; i >= 0; i--)
            {
                stack1.Push(a[i]);
            }
            for (int i = b.Count - 1; i >= 0; i--)
            {
                stack2.Push(b[i]);
            }


            // try to remove the values from one stack 
            while (totalsum < maxSum)
            {
                totalsum = totalsum + stack1.Peek();
                if (totalsum >= 0)
                {
                    stack1.Pop();
                    stack1pick++;
                }
            }
            result = stack1pick;

            //try remove from another stack if possible 
            // before going to other stack push last value to previous stack 

            for (int i = 0; i < b.Count; i++)
            {
                totalsum = totalsum + stack2.Peek();
                stack2pick++;
                while (totalsum > maxSum && stack1pick > 0)
                {
                    totalsum = totalsum - stack1.Peek();
                    stack1pick--;
                }
            }
            result = (totalsum <= maxSum) ? Math.Max(stack1pick + stack2pick, result) : result;
            return result;

        }
    }
}
