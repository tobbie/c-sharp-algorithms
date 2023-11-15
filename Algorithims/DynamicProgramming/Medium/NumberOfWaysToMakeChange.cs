using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming.Medium
{
    public class NumberOfWaysToMakeChange
    {
        public static int MakeChange(int n, int [] denominations)
        {
            var ways = new int[n + 1];
            ways[0] = 1;

            foreach (var denomination in denominations)
            {
                for (int amount = 0; amount < ways.Length; amount++)
                {
                    if (denomination <= amount)
                        ways[amount] += ways[amount - denomination];
                    
                }
            }

            return ways[n];
        }

       
    }
}
