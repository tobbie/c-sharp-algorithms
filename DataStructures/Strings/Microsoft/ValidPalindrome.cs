using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings.Microsoft
{
    public class ValidPalindrome
    {
        public static bool IsValid(string s)
        {
            s = s.ToLower();
            var charArray = s.Where(c => char.IsLetterOrDigit(c))
                            .ToArray();

            

            int leftPointer = 0;
            int rightPointer = charArray.Length - 1;

            while(leftPointer <= rightPointer)
            {
                if (charArray[leftPointer] != charArray[rightPointer])
                    return false;
                leftPointer++;
                rightPointer--;
            }

            return true;
        }
    }
}
