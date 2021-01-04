using System;
using static System.Console;

namespace DataStructures.Strings.Easy
{
    public class PalindromeCheck
    {
        public PalindromeCheck()
        {
        }

        public static void Run()
        {
            var testValue = "abcdcbax";

            WriteLine($"Is Palindrome:{OptimalSolution(testValue)}");
        }

        private static bool Solution1(string input)
        {
           
            var stringArray  = input.ToCharArray();
            //reverse string array
            int rightIndex = input.Length - 1;
            int leftIndex = 0;

            while(leftIndex < rightIndex)
            {
                var temp = stringArray[leftIndex];
                stringArray[leftIndex] = stringArray[rightIndex];
                stringArray[rightIndex] = temp;

                leftIndex++;
                rightIndex--;
            }

            string output = string.Join("", stringArray);

            return input.Equals(output);
        }

        //O(n) time, O(1) space.
        public static bool OptimalSolution(string input) {

            int leftIndex = 0, rightIndex = input.Length - 1;
            while (leftIndex <= rightIndex) {

                if (input[leftIndex] != input[rightIndex])
                    return false;

                leftIndex++;
                rightIndex--;
            }
            return true;
        }
    }
}
