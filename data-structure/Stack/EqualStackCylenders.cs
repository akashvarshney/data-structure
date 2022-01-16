using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Stack
{
    public class EqualStackCylenders
    {
        public static int equalStack(List<int> h1, List<int> h2, List<int> h3)
        {
            ///Create 3 stacks 
            Stack<int> stackh1 = new Stack<int>();
            Stack<int> stackh2 = new Stack<int>();
            Stack<int> stackh3 = new Stack<int>();
            int temp1 = 0; int temp2 = 0; int temp3 = 0;
            //Push Data to all 3 stacks and that would be from last 
            for (int i = h1.Count - 1; i >= 0; i--)
            {

                temp1 += h1[i];
                stackh1.Push(temp1);
            }
            for (int i = h2.Count - 1; i >= 0; i--)
            {

                temp2 += h2[i];
                stackh2.Push(temp2);
            }
            for (int i = h3.Count - 1; i >= 0; i--)
            {

                temp3 += h3[i];
                stackh3.Push(temp3);
            }


            while (true)
            {
                if (stackh1.Count == 0 || stackh2.Count == 0 || stackh3.Count == 0)
                    return 0;

                int stack1height = stackh1.Peek();
                int stack2height = stackh2.Peek();
                int stack3height = stackh3.Peek();
                if (stack1height == stack2height && stack2height == stack3height)
                    return stack1height;


                // which stack peek is highest value and pop that 
                if (stack1height >= stack2height && stack1height >= stack3height)
                {
                    stackh1.Pop();
                }
                else if (stack2height >= stack1height && stack2height >= stack3height)
                {
                    stackh2.Pop();
                }
                else if (stack3height >= stack1height && stack3height >= stack2height)
                {
                    stackh3.Pop();
                }
            }
        }
    }
}
