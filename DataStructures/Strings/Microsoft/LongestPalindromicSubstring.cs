using System;

namespace DataStructures.Strings.Microsoft
{
    public class PalindromicSubstring
    {
        //O(n^2) time, O(1) space;
        public static string LongestPalindoromeSubString(string input)
        {
            //Steps
            //1. Iterate over string starting at index 1;
            //2. For odd palindomes compare the two adjacent values to the element at the index, left and right.
            //3. For even plaindromes compare the element to the left of the index to the element at the index.
            //4. if elements are the same, then continue to expand further to the left and right, comparing each time.
            //5. As soon as the elements at the left and right don't match, return the indexes   of the left(+1), right pointers for the odd and even palindromes
            //6  compare the values of the odd and even palindoromes to determine the longest pair, 
            // 7. return the longest pair.

            int[] currentLongest = { 0, 1 }; // starting at {0, 1} cos first letter is a single character and is a plaindrome, element at index 1 is not included in substring character
            for (int index = 1; index < input.Length; index++)
            {
                var oddPalindrome = GetPlaindrome(input, index - 1, index + 1);
                var evenPalindrome = GetPlaindrome(input, index - 1, index);

                var longest = oddPalindrome[1] - oddPalindrome[0] > evenPalindrome[1] - evenPalindrome[0] ? oddPalindrome : evenPalindrome;
                currentLongest = currentLongest[1] - currentLongest[0] > longest[1] - longest[0] ? currentLongest : longest;
                
            }

            //return input[currentLongest[0]..currentLongest[1]];
           return input.Substring(currentLongest[0], currentLongest[1] - currentLongest[0]);


        }

        private static int[] GetPlaindrome(string input, int leftIndex, int rightIndex)
        {
            while(leftIndex >= 0 && rightIndex < input.Length)
            {
                if (input[leftIndex] != input[rightIndex])
                    break;
                else
                {
                    leftIndex--;
                    rightIndex++;
                }                                       
            }
            return new int[] { leftIndex + 1, rightIndex }; // not doing rightIndex - 1 becaudse we will use SubString method to return result, the endIndex is usually not inciluded in result.
        }
    }
}
