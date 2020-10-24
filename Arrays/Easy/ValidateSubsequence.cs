using System;
using System.Collections.Generic;
using System.Collections;


namespace Arrays.Easy
{
    public class ValidateSubSequence
    {

        public static void Run() {
            var array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            var sequence = new List<int>{ 22, 25, 6 };

            if (IsValidSubsequence3(array, sequence))
            {
                Console.WriteLine($"{true}, Input Sequence is a valid Subsequence");
            }
            else {
                Console.WriteLine($"{false}, Input Sequence is a not a valid Subsequence");
            }
           
            

        }

        private static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            int sequencePosition = 0;
            foreach (var item in array)
            {
                if ((sequence.Count - 1) == sequencePosition && (item == sequence[sequencePosition]))
                {
                    return true;
                }

                if (item == sequence[sequencePosition]) {
                    sequencePosition++;
                }

                
            }

            return false;
        }

        private static bool IsValidSubsequence2(List<int> array, List<int> sequence)
        {
            // Write your code here.

            
            int sequencePosition = 0;
            foreach (var item in array)
            {
                if ((sequence.Count - 1) == sequencePosition &&
                    IsitemInSquence(item, sequence, sequencePosition))
                {
                    return true;
                }

                if (IsitemInSquence(item, sequence, sequencePosition))
                {
                    sequencePosition++;
                }        

            }

            bool IsitemInSquence(int item, List<int> seq, int sequencePosition) {
                if (item == sequence[sequencePosition])
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        private static bool IsValidSubsequence3(List<int> array, List<int> sequence)
        {
            // Write your code here.
            int sequencePosition = 0;
            foreach (var item in array)
            {
                if (sequencePosition == sequence.Count) {
                    break;
                }
                if (item == sequence[sequencePosition])
                {
                    sequencePosition++;
                }
            }

            return sequence.Count == sequencePosition;
        }
    }
}
