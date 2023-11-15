using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming.Medium
{
   public class MaximumSumIncreasingSubsequence
    {
        public static List<List<int>> MaximumSum(int[] array)
        {
            var result = new List<List<int>>();
            var sums = new int[array.Length];
            var sequences = new int?[array.Length];
            Array.Copy(array, sums,array.Length);

            int maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                for (int j = 0; j <= i; j++)
                {
                    int otherNumber = array[j];
                    if (otherNumber < currentNumber && sums[j] + currentNumber >= sums[i])
                    {
                        sums[i] = sums[j] + currentNumber;
                        sequences[i] = j;
                        
                    }
                }

                if (sums[i] >= sums[maxIndex])
                    maxIndex = i;
            }

            
            

            result.Add(new List<int>() { sums[maxIndex] });
            result.Add(BuildSequence(array, sequences, maxIndex));
            return result;

           // result.First()[0]
        }

        private static List<int> BuildSequence(int[] array, int?[] sequences, int? currentIndex)
        {
            var sequence = new List<int>();
            while (currentIndex != null) {
                sequence.Add(array[(int)currentIndex]);
                currentIndex = sequences[(int)currentIndex];
            }

           sequence.Reverse();
           return sequence;
        }
    }
}
