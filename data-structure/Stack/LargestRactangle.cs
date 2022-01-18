using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure.Stack
{
    public class LargestRactangle
    {
        /// <summary>
        /// Bruteforce method
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public static long GetArea(List<int> h)
        {
            long acutalmaxheight = 0;
            List<long> height = new List<long>();
            for (int i = 0; i < h.Count; i++)
            {
                int leftMinHeightIndex = 0; int rightMinHeightIndex = 0; int leftMinHeight = 0; int rightMinHeight = 0;
                //find the nearest minimum height and index on left
                //traverse to left to find the nearest min height
                leftMinHeight = h[i];
                for (int left = i; left >= 0; left--)
                {
                    if (h[left] == 0)
                        break;
                    if (h[left] <= h[i] && h[left] != 0)
                    {
                        if (h[left] < leftMinHeight)
                        {
                            leftMinHeightIndex = left;
                            leftMinHeight = h[left];
                        }
                    }
                }

                //find the nearest minimum height and index on right
                //traverse to right to find the nearest min height
                rightMinHeight = h[i];
                for (int right = i; right < h.Count; right++)
                {
                    if (h[right] == 0)
                        break;

                    if (h[right] <= rightMinHeight && h[right] != 0)
                    {

                        rightMinHeightIndex = right;
                        rightMinHeight = h[right];

                    }
                }

                //get the index range and the value 
                int range = (rightMinHeightIndex - leftMinHeightIndex) + 1;
                // from my current value h[i] which value is smallest but not 0 
                int minvalue = 0;
                if (leftMinHeight == 0)
                {
                    minvalue = rightMinHeight;
                }
                else if (rightMinHeight == 0)
                {
                    minvalue = leftMinHeight;
                }
                else
                {
                    minvalue = leftMinHeight < rightMinHeight ? leftMinHeight : rightMinHeight;
                }

                //max possible height is 
                int maxpossibleHeightAtThisIndex = range * minvalue;
                height.Add(maxpossibleHeightAtThisIndex);
            }
            return acutalmaxheight;
        }

        /// <summary>
        /// using stack
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public static long GetlargestArea(List<int> h)
        {
            long acutalmaxheight = 0;
          
            return acutalmaxheight;
        }

    }
}
