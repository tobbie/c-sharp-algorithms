using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Algorithims.Recursion.Medium
{
    public static class Permutation
    {

        public static void Run()
        {
            var array = new int[] { 1, 2, 3};
          
            Util.Print2DArray(Permutations(array));
           
        }

        private static List<List<int>> GetPermutations(int[] array) {
            var permutations = new List<List<int>>();          
            GetPermutations(array.ToList(), new List<int>(), permutations);
            return permutations;
          
        }

        private static void GetPermutations(List<int> array, List<int> currentPermutation, List<List<int>> permutations)
        {
            if (array.Count == 0 && currentPermutation.Any())
                permutations.Add(currentPermutation);
            else
                for(int index = 0; index < array.Count; index++)
                {
                    var mutatedArray = new List<int>(array);
                    mutatedArray.RemoveAt(index);

                    var permutation = new List<int>(currentPermutation);
                    permutation.Add(array[index]);

                    GetPermutations(mutatedArray, permutation, permutations);
                }            
        }

        //The Really confusing optimal solution.O(n! *n) time, space is the first solution as above.
        private static List<List<int>> Permutations(int [] array) {
            var permutations = new List<List<int>>();

            permutationsHelper(0, array, permutations);
            return permutations;
               
        }

       
        private static void permutationsHelper(int currentIndex, int[] array, List<List<int>> permutations)
        {
            if (currentIndex == array.Length - 1)
                permutations.Add(array.ToList());
            else
            {
                for (int nextIndex=currentIndex; nextIndex < array.Length; nextIndex++)
                {
                    Swap(array, currentIndex, nextIndex);
                    permutationsHelper(currentIndex + 1, array, permutations);
                    Swap(array, currentIndex, nextIndex);

                }
            }
        }

        private static void Swap(int[]array, int currentIndex, int nextIndex) {
            var temp = array[currentIndex];
            array[currentIndex] = array[nextIndex];
            array[nextIndex] = temp;
            
        }
    }



}
