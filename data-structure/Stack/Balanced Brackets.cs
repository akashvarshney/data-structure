using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Stack
{
    public class Balanced_Brackets
    {
        public static string isBalanced(string s)
        {
            // first the strings are in even sets.
            if (s.Length % 2 != 0 || s.Length == 0)
            {
                return "NO";
            }
            else
            {
                char type1 = '{';
                char type2 = '[';
                char type3 = '(';

                Stack<char> stack1 = new Stack<char>();
                //split the string into two equal part  Or try it in one loop it self 
                for (int i = 0; i < s.Length; i++)
                {

                    if (s[i] == type1 || s[i] == type2 || s[i] == type3)
                    {
                        stack1.Push(s[i]);
                    }
                    if (stack1.Count != 0)
                    {
                        if (IsMatchType(stack1.Peek(), s[i]))
                        {
                            stack1.Pop();
                        }
                    }


                }
                return stack1.Count == 0 ? "YES" : "NO";

            }
        }

        public static bool IsMatchType(char type, char matchtype)
        {
            //find the type of char 
            if (type == '{' && matchtype == '}')
            {
                return true;
            }

            if (type == '(' && matchtype == ')')
            {
                return true;
            }

            if (type == '[' && matchtype == ']')
            {
                return true;
            }
            return false;
        }

    }
}
