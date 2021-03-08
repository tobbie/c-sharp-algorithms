using System;
using System.Linq;
using Common;

namespace DataStructures.Arrays.LeetCode
{
    public static class MoveElementToEnd
    {
        public static void Run() {
            var array = new int []{ 0, 1, 0, 3, 12 };
            Util.PrintList(OptimaSolution(array, 0).ToList());
        }

        private static int [] OptimaSolution(int [] nums, int toMove)
        {
            int currentPointer = 0, nextPointer = currentPointer + 1;
            while (nextPointer < nums.Length && currentPointer < nums.Length)
            {
                if (nums[currentPointer] != 0)
                {
                    currentPointer++;
                    nextPointer++;
                    continue;
                }

                if (nums[currentPointer] == 0 & nums[nextPointer] != 0)
                {
                    int temp = nums[nextPointer];
                    nums[nextPointer] = nums[currentPointer];
                    nums[currentPointer] = temp;
                    currentPointer++;
                    nextPointer++;
                }
                else if (nums[nextPointer] == 0)
                    nextPointer++;
            }
            return nums;
        }
    }
}
