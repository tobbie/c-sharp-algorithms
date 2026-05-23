using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Neetcode
{
    public static class BuySellStock
    {
        public static int MaxProfit(int[] prices)
        {
            /**
             * define two pointers, left = 0 and right  1 and define maxProfit variable as 0
             * while right pointer is less than prices.length
             * if value  at left pointer is greater than or equal to value at right pointer increment left pointer to right pointer value,
             * increment  right pointer by 1 then continue loop
             * other wise calculate current profit by subtracting value at left pointer from value at right pointer
             * assign maxProfit to the greater value between maxProfit and current profit
             * increment right pointer by 1
             * return maxProfit
            **/

            int left = 0;    int right = 1; int maxProfit = 0;
            while (right < prices.Length)
            {
                if (prices[left] >= prices[right]) 
                {
                    left = right;
                    right++;
                    continue;
                }

                int currentProfit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, currentProfit);
                right++;
            }

            return maxProfit;
        }
    }
}
