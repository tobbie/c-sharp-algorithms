using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SlidingWindow
{
   public class SmallestSubArrayWithGreaterSum
    {
        public static int FinMinSubArray(int S, int[] array)
        {
            int windowStart = 0;
            int minLength = int.MaxValue;
            int windowSum = 0;

            for (int windowEnd = 0; windowEnd < array.Length; windowEnd++)
            {
                windowSum += array[windowEnd];

                while(windowSum >= S)
                {
                    minLength = Math.Min(minLength, (windowEnd - windowStart) + 1);
                    windowSum -= array[windowStart];
                    windowStart += 1;               
                }
            }

            return minLength == int.MaxValue ? 0 : minLength;
        }
    }
}
