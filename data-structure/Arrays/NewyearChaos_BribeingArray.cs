using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Arrays
{
    public class NewyearChaos_BribeingArray
    {
        public static string minimumBribe(List<int> list)
        {
            string result = string.Empty;
            int totalbribe = 0;
            int currentItem = 0;
            int nextItem = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int currentItemBribes = 0;
                currentItem = list[i];
                nextItem = i < list.Count - 1 ? list[i + 1] : list[i];

                //condition when last index 
                if (currentItem == nextItem)
                {

                }
                else if (currentItem > nextItem)
                {
                    currentItemBribes = currentItem - nextItem;
                    totalbribe = totalbribe + currentItemBribes;
                    if (currentItemBribes > 2)
                    {
                        result = "Too Cheoas";
                    }

                }
                break;

            }
            result = totalbribe.ToString();
            return result; ;


        }

        public static void minimumBribes2(List<int> list)
        {
            int swapcount = 0;
            bool notchaotic = false;

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] != i + 1)
                {
                    if ((i - 1) >= 0 && list[i - 1] == (i + 1))
                    {
                        swapcount++;
                        swap(list, i, i - 1);
                    }
                    else if ((i - 2) >= 0 && list[i - 2] == (i + 1))
                    {
                        swapcount = swapcount + 2;
                        swap(list, i - 2, i - 1);
                        swap(list, i, i - 1);
                    }
                    else
                    {
                        Console.WriteLine("Too chaotic");
                        notchaotic = true;
                        break;
                    }
                }
            }
            if (swapcount > 0 && !notchaotic)
                Console.WriteLine(swapcount);


        }
        private static void swap(List<int> list, int i, int v)
        {
            int temp = 0;
            temp = list[i];
            list[i] = list[v];
            list[v] = temp;


        }

    }
}
