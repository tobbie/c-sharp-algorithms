using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Arrays.Hard
{
    public static class SubarraySort
    {
        public static void Run()
        {

            var inputArray = new int[] { 1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19 };
            var inputArray2 = new int[] { 1, 2, 4, 7, 10, 11};

            Util.PrintList(OptimalSolution1(inputArray2).ToList());

        }

        private static int[] OptimalSolution1(int [] inputArray) {

            if (inputArray.Length < 2)
                return new int[0];


            int leftIndex = 1, rightIndex = inputArray.Length - 2;
            int leftPointer = leftIndex - 1, rightPointer = rightIndex + 1;
            int indexOfSmallestUnsortedNumber = -1, indexOfLargestUnsortedNumber = -1;

            while (leftIndex < inputArray.Length & rightIndex >= 0) {

                //find index of Smallest Unsorted Nubmber
                if (inputArray[leftIndex] < inputArray[leftPointer])
                {

                    indexOfSmallestUnsortedNumber = leftIndex;
                    leftPointer = leftIndex;
                    leftIndex++;
                }
                else if (inputArray[leftIndex] > inputArray[leftPointer] & leftPointer == indexOfSmallestUnsortedNumber)
                    leftIndex++;
                else if (inputArray[leftIndex] >= inputArray[leftPointer])
                {
                    leftPointer = leftIndex;
                    leftIndex++;
                }


                //find index of Largest Unsorted Number

                if (inputArray[rightIndex] > inputArray[rightPointer])
                {
                    indexOfLargestUnsortedNumber = rightIndex;
                    rightPointer = rightIndex;
                    rightIndex--;
                }
                else if (inputArray[rightIndex] < inputArray[rightPointer] & rightPointer == indexOfLargestUnsortedNumber)
                    rightIndex--;
                else if (inputArray[rightIndex] <= inputArray[rightPointer])
                {
                    rightPointer = rightIndex;
                    rightIndex--;
                }
            }


            if (indexOfLargestUnsortedNumber >= 0 & indexOfSmallestUnsortedNumber >= 0)
            {
                return GetIndexOfUnsortedSubArray(indexOfSmallestUnsortedNumber,
               indexOfLargestUnsortedNumber, inputArray);
            }
            else
                return new int[] { -1, -1 };

        }


        private static int[] GetIndexOfUnsortedSubArray(int smallest, int largest, int[] inputArray) {

            int minIndex = -1, maxIndex = -1, leftIndex = 0, rightIndex = inputArray.Length -1;

            var result = new List<int>();

            while (leftIndex < inputArray.Length & rightIndex >= 0) {

                if (minIndex == leftIndex & maxIndex == rightIndex)
                    break;

                if (inputArray[smallest] < inputArray[leftIndex])
                    minIndex = leftIndex;
                else
                    leftIndex++;


                if (inputArray[largest] > inputArray[rightIndex])
                    maxIndex = rightIndex;
                else
                    rightIndex--;

                
            }

            result.Add(minIndex);
            result.Add(maxIndex);

            return result.ToArray();

        }

        
    }
}
