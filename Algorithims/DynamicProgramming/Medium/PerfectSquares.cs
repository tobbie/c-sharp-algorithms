using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.DynamicProgramming.Medium
{
  public class PerfectSquares
    {
        public static int NumSquares(int n)
        {
            var memo = new Dictionary<int, double>();
            return (int)NumSquaresHelper(n, memo);
        }

        private static double NumSquaresHelper(int n, Dictionary<int, double> memo)
        {
            if (memo.ContainsKey(n))
                return memo[n];

            if (n == 0)
                return 0;

            double minmumSquares = double.PositiveInfinity;

            for(int i = 1;  i <= Math.Sqrt(n);  i++)
            {
                int square = i * i;
                double sumSquares = 1 + NumSquaresHelper(n - square, memo);
                minmumSquares = Math.Min(minmumSquares, sumSquares);
                
            }

            memo.Add(n, minmumSquares);
            return memo[n];
        }
    }


}
