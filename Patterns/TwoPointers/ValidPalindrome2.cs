using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TwoPointers
{
    public class ValidPalindrome2
    {
        public static bool IsValid(string inputString)
        {
            int left = 0;
            int right = inputString.Length -1;

            int start = 0;
            int end = 0;

            bool leftResult = true;
            bool rightResult = true;

            while (left < right)
            {
                if (inputString[left] != inputString[right])
                {
                    start = left;
                    end = right;
                    break;
                }          
                   
                left++;
                right--;
            }

          
            while(left < right -1)
            {
                if (inputString[left] != inputString[right - 1])
                {
                    leftResult = false;
                    break;
                }
                    
                left++;
                right--;
            }

            if(leftResult)
                return true;

            left = start; right = end;
            while(left + 1 < right)
            {
                if (inputString[left + 1] != inputString[right])
                {
                    rightResult = false;
                    break;
                }
                 
                left++;
                right--;
            }

            return leftResult || rightResult;
        }
    }
}
