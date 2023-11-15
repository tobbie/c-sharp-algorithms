using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Algorithms.BitwiseOperation
{
    public class NumberOfSteps
    {
        public static int Steps(string s)
        {
            var number = ConvertToBigInt(s);

            int steps = 0;
            while(number != 1)
            {
                if (number % 2 != 0)
                    number += 1;
                else
                    number /= 2;

                steps += 1;
            }

            return steps;
        }

        private static BigInteger ConvertToBigInt(string s)
        {
            BigInteger number = 0;

            for (int i = 0; i < s.Length; i++)          
                number = (number * 2) + (s[i] == '1' ? 1 : 0);
            return number;
            
        }
    }
}
