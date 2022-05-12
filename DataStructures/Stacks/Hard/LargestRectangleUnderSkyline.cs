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
        public static int LargestRectangleArea(int [] inputArray)
        {
            if (inputArray.Length == 0)
                return 0;

            int maxArea = 0;
            int leftPosition;
            int rightPosition;
            int currentWidth;

            for(int index = 0; index < inputArray.Length; index++)
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
    }
}
