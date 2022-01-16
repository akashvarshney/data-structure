using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Stack
{
    public class MaximumElement
    {
        public enum QueryType
        {
            Push = 1,
            Pop = 2,
            PrintMax = 3,
        }
        public static List<int> getMax(List<string> operations)
        {
            List<int> result = new List<int>();
            Stack<int> MainStack = new Stack<int>();
            Stack<int> MaxStack = new Stack<int>();
            foreach (string operation in operations)
            {
                //split the operation
                int value = int.MinValue;
                var split = operation.Split(' ');
                int type = int.Parse(split[0]);
                if (split.Length > 1)
                {
                    value = int.Parse(split[1]);
                }

                switch (type)
                {
                    case 1:
                        MainStack.Push(value);
                        int maxval = MaxStack.Count == 0 ? value : MaxStack.Peek();
                        if (value > maxval)
                            MaxStack.Push(value);
                        else
                            MaxStack.Push(maxval);
                        break;
                    case 2:
                        MainStack.Pop();
                        MaxStack.Pop();
                        break;
                    case 3:
                        result.Add(MaxStack.Peek());
                        break;
                    default:
                        break;
                }
            }

            return result;
        }
    }
}
