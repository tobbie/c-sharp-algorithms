using System;
using System.Linq;

namespace DataStructures.Arrays.Medium
{
    public static class ArrayOfProducts
    {
        public static void Run()
        {
            var inputArray = new int[] { 5, 1, 4, 2 };
            Util.PrintList(OptimalSolution(inputArray).ToList());
        }

        public static int[] Solution1(int[] inputArray) {

            if (inputArray.Length < 2)
                return new int[] { };

            var outputArray = new int[inputArray.Length];

            for (int index = 0; index < inputArray.Length; index++)
            {
                int leftPointer = -1, rightPointer = index + 1, leftProduct = 1, rightProduct = 1;
                if (index > 0)
                    leftPointer = index - 1;

                while (leftPointer >= 0) {
                    leftProduct = leftProduct * inputArray[leftPointer];
                    leftPointer--;
                }

                while (rightPointer < inputArray.Length) {
                    rightProduct = rightProduct * inputArray[rightPointer];
                    rightPointer++;
                }

                outputArray[index] = leftProduct * rightProduct;
            }

            return outputArray;

        }

        public static int[] OptimalSolution(int[] inputArray) {

            if (inputArray.Length < 2)
                return new int[] { };

            int index = 0;
            int leftRunningProduct = 1;
            var outputArray = new int[inputArray.Length];

            //iterate left to right each time computing the product of  all the values to the
            //left of your pointer value, store in an array

            while (index < inputArray.Length) {
                if (index == 0)
                    leftRunningProduct *= 1;
                else
                    leftRunningProduct *= inputArray[index - 1];


                outputArray[index] = leftRunningProduct;
                index++;
            }

            index = inputArray.Length - 1;
            int rightRunningProduct = 1;

            //iterate right to left each time computing the product of  all the values to the right of your pointer value,
            //multiply by current value in output array computed in the L > R loop
            
            while (index >= 0) {
                if (index == inputArray.Length - 1)
                    rightRunningProduct = 1 * rightRunningProduct;
                else
                    rightRunningProduct *= inputArray[index + 1];

                    outputArray[index] *= rightRunningProduct;
                    index--;
             }

             return outputArray;

            }
        }
    }
