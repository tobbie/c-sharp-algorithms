using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.DynamicProgramming.Medium
{
    // max sum non adjacent
  public class HouseRobber
    {
        public int Rob(int[] nums)
        {
            var memo = new Dictionary<int, int>();
            return RobHelper(nums,0, memo);
        }

        private int RobHelper(int[] nums, int index, Dictionary<int, int> memo)
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
    }
}
