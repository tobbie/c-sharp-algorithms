using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TwoPointers
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string input)
        {
            int leftPointer = 0;
            int rightPointer = input.Length - 1;

            while (leftPointer < rightPointer)
            {
                if (input[leftPointer] != input[rightPointer]) 
                    return false;

                leftPointer++;
                rightPointer--;

            }

            return true;
        }
    }
}
