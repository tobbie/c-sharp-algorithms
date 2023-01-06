using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FastAndSlow
{
    public class CircularArray
    {
        public static bool HasLoop(int[] nums)
        {
            int slow = 0, fast = 0;
            bool currentDirection = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i]) == nums.Length)
                    continue;

                if (nums[i] > 0)
                    currentDirection = true;
                else
                    currentDirection = false;

                slow = i;
                fast = i;

                while(slow != fast || slow != -1 || fast != -1)
                {
                    slow = NextStep(slow, nums, currentDirection);
                    if (slow == -1)
                        break;

                    fast = NextStep(fast, nums, currentDirection);
                    if (fast != -1)
                    {
                        fast = NextStep(fast, nums, currentDirection);
                    }

                    if (slow == fast || fast == -1)
                        break;

                }

                if (slow == fast && slow != -1)
                    return true;
            }

            return false;
        }

        private static int NextStep(int index, int[] nums, bool currentDirection)
        {
            bool newDirection = false;
            if (nums[index] >= 0)
                newDirection = true;
            else
                newDirection = false;

            if(currentDirection != newDirection || (Math.Abs(nums[index] % nums.Length) == 0))
                    return -1;

            int nextStep = index + nums[index];
            nextStep = nextStep % nums.Length;

            if (nextStep < 0)
                nextStep = nextStep + nums.Length;

            return nextStep;
        }
    }
}
