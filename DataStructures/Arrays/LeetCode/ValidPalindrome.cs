using System;
using static System.Console;

namespace DataStructures.Arrays.LeetCode
{
    public class ValidPalindrome
    {
        public ValidPalindrome()
        {
        }

        public static void Run() {
            // "A man, a plan, a canal: Panama"
           // "race a car"
            string input = "race a car";
            WriteLine($"Is Palindrome :{OptimalSolution(input)}");
        }

        private static bool OptimalSolution(string input) {

            if (input == null)
                return false;            
            else if(string.IsNullOrWhiteSpace(input))
                return true;
            else if (input.Length == 1)
                return true;

            int leftPointer= 0, rightPointer = input.Length - 1;
            while(leftPointer <= rightPointer)
            {
                if (!char.IsLetterOrDigit(input[leftPointer])) {
                    leftPointer++;
                    continue;
                }

                if (!char.IsLetterOrDigit(input[rightPointer]))
                {
                    rightPointer--;
                    continue;
                }

                if (char.ToLower(input[leftPointer]) != char.ToLower(input[rightPointer]))
                    return false;

                leftPointer++;
                rightPointer--;
            }

            return true;
        }

        
    }
}
