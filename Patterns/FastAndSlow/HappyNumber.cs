using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FastAndSlow
{
    public class HappyNumber
    {
        public bool IsHappy(int number)
        {
            int slow = number;
            int fast = SumOfDigits(number);

            while(fast != 1 && slow != fast)
            {
                slow = SumOfDigits(slow);
                fast = SumOfDigits(SumOfDigits(fast));
            }

            return fast == 1;
        }

        private int SumOfDigits(int number)
        {
           int totalSum = 0;
            while(number != 0)
            {
                int digit = number % 10;
                totalSum += (int)Math.Pow(digit, 2);
                number /= 10;
            }
            return totalSum;
        }


    }
}
