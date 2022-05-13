using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stacks.Hard
{
    public class LargestRectangleUnderSkyline
    {
        //O(n^2) time O(1) space
        public static int LargestRectangleArea(int[] inputArray)
        {
            if (inputArray.Length == 0)
                return 0;

            int maxArea = 0;
            int leftPosition;
            int rightPosition;
            int currentWidth;

            for (int index = 0; index < inputArray.Length; index++)
            {
                leftPosition = index - 1;
                rightPosition = index + 1;
                currentWidth = 1;

                //   <----expand left  
                while (leftPosition >= 0)
                {
                    if (inputArray[index] <= inputArray[leftPosition])
                        currentWidth++;
                    else
                        break;
                    leftPosition--;

                }

                //expand right ------->
                while (rightPosition < inputArray.Length)
                {
                    if (inputArray[index] <= inputArray[rightPosition])
                        currentWidth++;
                    else
                        break;

                    rightPosition++;
                }

                maxArea = Math.Max(maxArea, currentWidth * inputArray[index]);
            }

            return maxArea;
        }

        public static int LargestRectangleArea2(List<int> buildings)
        {
            if (buildings.Count == 0)
                return 0;

            var stack = new List<int>();
            int maxArea = 0;
            buildings.Add(0);

            for (int index = 0; index < buildings.Count; index++)
            {
                while(stack.Count != 0  && buildings[stack[stack.Count -1]] >= buildings[index])             
                {
                    int pillarHeight = buildings[stack[stack.Count - 1]];
                    stack.RemoveAt(stack.Count - 1);
                    int width = stack.Count == 0 ? index : (index - stack[stack.Count - 1]) -1;

                    maxArea = Math.Max(width * pillarHeight, maxArea);
                }

                stack.Add(index);
            }

            return maxArea;

        }
    }
}
