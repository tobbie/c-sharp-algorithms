using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SlidingWindow
{
    public class MinimumSizeSubArraySum
    {
        public static int  FindMinimumSize(int[] array, int target)
        {
            
            int leftIndex = 0;
            int runningSum = 0;
            int rightIndex = 0;
            int minimumLength = int.MaxValue;

            while(rightIndex< array.Length)
            {
                runningSum += array[rightIndex];

                while(runningSum >= target)
                {
                    int currentSize =  (1 + rightIndex) - leftIndex;

                    minimumLength = Math.Min(minimumLength, currentSize);
                 
                    runningSum -= array[leftIndex];
                    leftIndex += 1;              
                }

                rightIndex++;
            }

            return minimumLength != int.MaxValue ? minimumLength : 0;




        }
    }
}
