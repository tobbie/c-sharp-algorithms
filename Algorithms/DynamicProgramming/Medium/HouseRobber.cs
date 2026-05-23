using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming.Medium
{
    // max sum non adjacent
  public static class HouseRobber
    {
        public static int Rob(int[] nums)
        {
            var memo = new Dictionary<int, int>();
            return RobHelper(nums,0, memo);
        }

        private static int RobHelper(int[] nums, int index, Dictionary<int, int> memo)
        {
            if (memo.ContainsKey(index))
                return memo[index];

            if (index >= nums.Length)
                return 0;

            int pickFirst = nums[index] + RobHelper(nums, index + 2, memo);
            int pickSecond = RobHelper(nums, index + 1, memo);

            memo.Add(index, Math.Max(pickFirst, pickSecond));
            return memo[index];
        }

        //DP solution

        public static int RobHouses(int[] nums)
        {
            //if (nums.Length < 2)
            //    return nums[0];

           
            var maxLoot = new int[nums.Length];

            maxLoot[0] = nums[0];
            maxLoot[1] = Math.Max(nums[0], nums[1]);

            for (int n = 2; n < nums.Length; n++)
            {
                maxLoot[n] = Math.Max( maxLoot[n - 2] + nums[n], maxLoot[n - 1]);
             }

            return maxLoot[nums.Length -1];
        }

        public static int RobsCicularHouses(int[] nums)
        {
            if (nums.Length < 2)
                return nums[0];
            if (nums.Length == 2)
                return Math.Max(nums[0], nums[1]);

            int[] skipLast = new int[nums.Length - 1];
            int[] skipFirst = new int[nums.Length - 1];


            for (int i = 0; i < nums.Length - 1; i++)
            {
                skipLast[i] = nums[i];
                skipFirst[i] = nums[i + 1];
            }

            var skipLastMax = RobHouses(skipLast);
            var skipFirstMax = RobHouses(skipFirst);

            return Math.Max(skipLastMax, skipFirstMax);
        }
    }
}
