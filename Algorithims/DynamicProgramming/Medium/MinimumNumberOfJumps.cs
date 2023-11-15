using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming.Medium
{
 public class MinimumNumberOfJumps
    {
        //[3, 4, 2, 1, 2, 3, 7, 1, 1, 1 3]
        public static int MinumumJumps(int[] array) {
            if (array.Length == 1)
                return 0;

            int jumps = 0;
            int maximumReach = array[0];
            int steps = array[0];

            for (int index = 1; index < array.Length - 1; index++)
            {
                maximumReach = Math.Max(maximumReach, array[index] + index);
                steps -= 1;
                if(steps == 0)
                {
                    jumps += 1;
                    steps = maximumReach - index;
                }
            }

            return jumps + 1;
        }
    }
}
