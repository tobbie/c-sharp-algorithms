using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming.Medium
{
    public class MaxSumsNoAdjacent
    {
        // time : O(n) | spcace :O(n)
        public static int MaxSubsetSumNoAdjacent(int[] array)
        {
            //[7,  10,12,  7, 9, 14]
            //maxSums[i] = Max( MaxSums[i-1] , MaxSums[i-2] + array[i])
            if (array.Length == 0) return 0;
            if (array.Length == 1) return array[0];

            var maxSums = new int[array.Length];
            maxSums[0] = array[0];
            maxSums[1] = Math.Max(array[1], array[0]);

            for (int index = 2; index < array.Length; index++)
            {
                maxSums[index] = Math.Max(maxSums[index - 1], maxSums[index - 2] + array[index]);
            }

            return maxSums[array.Length - 1];
        }

        public static int MaxSubsetSumNoAdjacent(int[] array, bool lowSpace = true)
        {
            if (array.Length == 0) return 0;
            if (array.Length == 1) return array[0];

            int second = array[0];
            int first = Math.Max(array[1], array[0]);

            for (int index = 2; index < array.Length; index++)
            {
                int current = Math.Max(first, second + array[index]);
                second = first;
                first = current;
            }

            return first;
        }
    }
}
