using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TwoPointers
{
   public class ThreeSum
    {
        // ( n log (n) + n^2) 
        public static bool FindSumOfThree(int[] array, int target)
        {

            Array.Sort(array);

            for (int index = 0; index < array.Length -2; index++)
            {
                int low = index + 1;
                int high = array.Length - 1;

                while(low < high)
                {
                    int currentSum = array[index] + array[low] + array[high];
                    if (currentSum == target)
                        return true;
                    else if (currentSum < target)
                        low += 1;
                    else
                        high -= 1;
                }

            }
            return false;
        }
    }
}
