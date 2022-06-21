using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Algorithims.DynamicProgramming.Hard
{
  public class WaterArea
    {
        /**
         * 1. Iterate over heights from left to right.
         * 2. for each index find the tallest piller that is to the left of the index;, record this in another array called leftmax. LeftMax starts with 0, the value of first index is 0.
         * 3. Iterate over the heights again this time from right to left, 
         * 4. for each index find the tallest piller that's to the right of the index, record this in another array called rightMax. rightMax starts with 0, the value of last index from right is 0
         * 5. In a tird array compute the minmum height of the vlaues for eeach index in the leftMax and rightMax arrays
         * 6. The water area formula is w = height < minHeight ? minHeight - height : 0; Do this for each index.
         * 7. return the total sum of all values in the water array.
         * **/
        public static int Compute(int[] heights)
        {
            int[] leftMaxList = new int[heights.Length];
            int[] rightMaxList = new int[heights.Length];
            int[] waterArea = new int[heights.Length];
            int leftMax = 0;
            int rightMax = 0;

            for (int i = 1; i < heights.Length; i++)
            {
                leftMax = Max(leftMax, heights[i - 1]);
                leftMaxList[i] = leftMax;
            }

            for (int rightIndex = heights.Length -2; rightIndex >= 0; rightIndex--)
            {
                rightMax = Max(rightMax, heights[rightIndex + 1]);
                rightMaxList[rightIndex] = rightMax;
            }

            for (int index = 0; index < waterArea.Length; index++)
            {
                int minHeight = Min(leftMaxList[index], rightMaxList[index]);
                waterArea[index] = heights[index] < minHeight ? minHeight - heights[index] : 0;
            }

            return waterArea.Sum();
        }


        public static int ComputeTrappedWater(int[] heights)
        {
            int[] leftMaxList = new int[heights.Length];
            int[] waterArea = new int[heights.Length];
            int leftMax = 0;
            int rightMax = 0;

            for (int i = 1; i < heights.Length; i++)
            {
                leftMax = Max(leftMax, heights[i - 1]);
                leftMaxList[i] = leftMax;
            }

            for (int index = heights.Length - 2; index >= 0; index--)
            {
                rightMax = Max(rightMax, heights[index + 1]);
                int minHeight = Min(rightMax, leftMaxList[index]);
                waterArea[index] = heights[index] < minHeight ? minHeight - heights[index] : 0;
            }

            return waterArea.Sum();
        }
    }
}
