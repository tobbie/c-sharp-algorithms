using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using Common;


namespace DataStructures.Strings.Meduim
{
    public static class LongestPalindromicSubstring
    {
        private static int _length = -1;
        private static List<int> _result = new List<int>();

        public static void Run() {

            var input = "abcdefghfedcbaa";
            WriteLine(OptimalSolution(input));
        }

        private static string OptimalSolution(string str) {

            //edge case.
            if (str.Length == 1)
                return str;
            

            for (int index = 0; index < str.Length; index++)
            {
                //edge case
                if (index == 0) {
                    _length = 1;
                    _result = new List<int> {index};               
                    continue;
                }

                int previous = index - 1, next = index + 1;

                next = next >= str.Length ? index : next; //handle edgecase for when palindrome is at end of string.

                if (str[previous] != str[next] & str[previous] != str[index])
                    continue;

                //preserve original Previous and Index pointers
                int oddPrevious = previous , evenPrevious = previous; 
                int evenIndex = index;

                bool adjacentValuesAreEqual = (oddPrevious > -1) && (next < str.Length) && (str[oddPrevious] == str[next]) ;
                while (adjacentValuesAreEqual)
                {
                    int currentPalindromeLength = (next - oddPrevious) + 1;
                    SetLongestPalindrome(currentPalindromeLength, oddPrevious);
                    oddPrevious--;
                    next++;
                    adjacentValuesAreEqual = (oddPrevious > -1) && (next < str.Length) && (str[oddPrevious] == str[next]);
                }

                bool previousValueEqualToCurrentValue = (evenPrevious > -1) && (evenIndex < str.Length) && (str[evenPrevious] == str[evenIndex]);
                while (previousValueEqualToCurrentValue) {
                    int currentPalindromeLength = (evenIndex - evenPrevious) + 1;
                    SetLongestPalindrome(currentPalindromeLength, evenPrevious);
                    evenPrevious--;
                    evenIndex++;
                    previousValueEqualToCurrentValue = (evenPrevious > -1) && (evenIndex < str.Length) && (str[evenPrevious] == str[evenIndex]);
                }
                

            }

            if (_result.Any())
            {
                return str.Substring(_result[0], _result[1]);
            }
            else
                return string.Empty;



        }

        private static void SetLongestPalindrome(int currentLength, int previousIndex) {
            if (currentLength > _length)
            {
                _length = currentLength;
                _result = new List<int> { previousIndex, _length };
            }
        }

    }
}
