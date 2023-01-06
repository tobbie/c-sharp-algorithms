using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SlidingWindow
{
  public class BestTimeToBuyStock
    {
        public static int MaxProfit(int[] array)
        {
            if (array.Length <= 0)
                return 0;
            int leftIndex = 0;
            int rightIndex = 1;
            int maxProfit = 0;

            while(rightIndex < array.Length)
            {
                if (array[rightIndex] <= array[leftIndex])
                {
                    leftIndex = rightIndex;
                }
                else
                {
                    int currentProfit = array[rightIndex] - array[leftIndex];
                    maxProfit = Math.Max(maxProfit, currentProfit);
                }
                rightIndex += 1;
            }

            return maxProfit;
        }
    }
}
