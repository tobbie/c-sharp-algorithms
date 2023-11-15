using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Algorithms.Recursion.Easy;

namespace Algorithms.DynamicProgramming.Medium
{
    public class NumberOfWaysToTraverseGraph
    {
        public static int NumberOfWays(int width, int height) {
            // (r + d) ! / r ! * d !

            // r = height -1
            // d - width - 1

            int waysRight = width - 1;
            int waysDown = height - 1;

           // BigInteger xy = 293993939;

             BigInteger numerator = Factorial.GetFactorialIterative(waysRight + waysDown);
             BigInteger denominator = Factorial.GetFactorialIterative(waysRight) * Factorial.GetFactorialIterative(waysDown);

            return (int) (numerator / denominator);
        }

    }
}
