using System;
using System.Collections.Generic;

namespace DataStructures.Arrays.Neetcode
{
    public static class MaxiumSlidingWindow
    {
        public static List<int> MaximumSlidingWindow(int[] nums, int k)
        {
            int left = 0; int right = 0; int currentMax = int.MinValue;
            var result = new List<int>();

            while (k <= nums.Length)
            {
               while(right < k) 
               {
                    currentMax = Math.Max(currentMax, nums[right]);
                    right++;
               }
               result.Add(currentMax);
               left++; right = left; k++;
               currentMax = int.MinValue;

            }

            return result;
        }
    }
}
