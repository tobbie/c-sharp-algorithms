using System;
using System.Collections.Generic;

namespace DataStructures.Arrays.Hard
{
    public static class FourNumberSum
    {
       
        public static void Run() {

            // var inputArray = new int[] { 7, 6, 4, -1, 1, 2 };
            var inputArray = new int[] { 5, -5, -2, 2, 3, -3};
            int targetSum = 0;

            Util.Print2DArray(OptimalSolution(inputArray, targetSum));
        }

        private static List<int[]> OptimalSolution(int[] array, int targetSum) {

            var result = new List<int[]>();
            var hashTable = new Dictionary<int, List<List<int>>>();
            int index = 1;

            while (index < array.Length) {
                int leftPointer = index - 1;
                int rightPointer = index + 1;

                while (rightPointer < (array.Length)) {

                    int resultQ = targetSum - (array[index] + array[rightPointer]);

                    if (hashTable.ContainsKey(resultQ))
                    {
                        //get key value 2d array
                        var keyPairArray = hashTable.GetValueOrDefault(resultQ);

                        foreach (var pair in keyPairArray) // worst case is O(n^3)
                        {
                            var currentPair = new List<int>();
                            currentPair.AddRange(pair);                           
                            currentPair.Add(array[index]);
                            currentPair.Add(array[rightPointer]);
                            result.Add(currentPair.ToArray());
                           
                        }                   
                    }

                    rightPointer++;
                }


                while (leftPointer >= 0) {

                    var pair = new List<int>();
                   
                    int sumQ = array[index] + array[leftPointer];
                    pair.Add(array[leftPointer]);
                    pair.Add(array[index]);

                    if (!hashTable.ContainsKey(sumQ))
                    {
                        var pairArray = new List<List<int>>();
                        pairArray.Add(pair);
                        hashTable.Add(sumQ, pairArray);

                    }
                    else                                        
                        hashTable.GetValueOrDefault(sumQ).Add(pair);

                    leftPointer--;
                }
                index++;
            }

            return result;

        }
    }
}
