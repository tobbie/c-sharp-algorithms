using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Algorithms.DynamicProgramming.Medium
{   
    public class MinimumCoins
    {
        public static long MinCoins(int amount, int[]coins)
        {
            var memo = new Dictionary<int, long>();
             var result = MinCoinsHelper(amount, coins, memo);
             return result >= int.MaxValue ? -1 : result;
                             
        }

        public static long MinCoinsHelper(int amount, int[] coins, Dictionary<int, long> memo)
        {
            
            if (memo.ContainsKey(amount))
                return memo[amount];

            if (amount < 0)
                return int.MaxValue;
            

            if (amount == 0)
                return 0;

            long minimumCoins = int.MaxValue;

            foreach (var coin in coins)
            {
                long numberOfCoins = 1 + MinCoinsHelper(amount - coin, coins, memo);
                minimumCoins = minimumCoins < numberOfCoins ? minimumCoins : numberOfCoins;
            }

            memo[amount] = minimumCoins;
            return minimumCoins;
        }
    }
}
