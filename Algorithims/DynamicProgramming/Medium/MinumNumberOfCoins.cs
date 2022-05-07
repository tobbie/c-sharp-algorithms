using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.DynamicProgramming.Medium
{
    public class MinumNumberOfCoins
    {
        public static int MinimumCoins(int n, int[] denoms) {
            //initilize array of numberOfCoins to infinity,
            // coins[i] = Min(coins[i], 1 + coin[amount - denom]);

            if (n < 0) return -1;
            if (n == 0) return 0;

            var numberOfCoins = new Double[n + 1];
            for (int index = 1; index < numberOfCoins.Length; index++)
                numberOfCoins[index] = double.PositiveInfinity;

            foreach (var denom in denoms)
            {
                for (int amount = 0; amount < numberOfCoins.Length; amount++)
                {
                    if(denom <= amount)
                        numberOfCoins[amount] = Math.Min(numberOfCoins[amount], 1 + numberOfCoins[amount - denom]);
                }
            }

            return numberOfCoins[n] != double.PositiveInfinity ? (int)numberOfCoins[n] : -1 ;
        }
    }
}
