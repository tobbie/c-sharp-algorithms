using System;
using System.Collections.Generic;
using static System.Console;

namespace Arrays.Medium
{
    public class ThreeNumberSumTest
    {
        public ThreeNumberSumTest()
        {
        }

        public static void Run()
        {
            int[] testArray = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
            int targetSum = 0;

            var result = ThreeNumberSum(testArray, targetSum);
            Write("[ ");
            foreach (var item in result)
            {
                Write("[");
                foreach (var intValue in item) {

                    Write($"{intValue} ");
                }

                Write("],");

                

            }
            Write(" ]");
            ReadLine();
        }


       


        public static List<int[]> ThreeNumberSum(int[] array, int targetSum) {

            int currentNumber, leftNumber, rightNumber, sum = 0;
            var resultList = new List<int[]>();

            Array.Sort(array);

            for (int index = 0; index < array.Length; index++) {

                int leftPointer = index + 1;
                int rightPointer = array.Length - 1;
                

                if (leftPointer == rightPointer) {
                    break;
                }

                currentNumber = array[index];

                while ((leftPointer < rightPointer))
                {
                    var triplet = new int[3];

                    rightNumber = array[rightPointer];
                    leftNumber = array[leftPointer];
                    sum = currentNumber + leftNumber + rightNumber;

                    if (sum < targetSum)
                    {
                        leftPointer++;


                    }
                    else if (sum > targetSum)
                    {
                        rightPointer--;
                    }
                    else
                    {
                        triplet[0] = currentNumber;
                        triplet[1] = leftNumber;
                        triplet[2] = rightNumber;
                        //Array.Sort(triplet);
                        resultList.Add(triplet);
                        rightPointer--;
                        leftPointer++;

                    }

                }         

            }

            return resultList;

        }


        public static List<int[]> ThreeNumberSumPartial(int[] array, int targetSum)
        {
            // Write your code here.
            var hashTable = new HashSet<int>();

            var resultArray = new List<int[]>();

            for (int index_1 = 0; index_1 < array.Length; index_1++)
            {


                int firstNumber = array[index_1];
                int newTargetSum = targetSum - firstNumber;

                for (int index_2 = index_1 + 1; index_2 < array.Length; index_2++)
                {
                    var tripletArray = new int[3];
                    hashTable.Add(array[index_2]);
                    int secondNumber = array[index_2];

                    if (newTargetSum == secondNumber) { continue; }

                    int result = newTargetSum - secondNumber;

                    if (result == firstNumber || result == secondNumber) { continue; }



                    if ((hashTable.Contains(result)) && (Array.IndexOf(array, result) >= index_1))
                    {
                        tripletArray[0] = firstNumber;
                        tripletArray[1] = secondNumber;
                        tripletArray[2] = result;
                        Array.Sort(tripletArray);

                        resultArray.Add(tripletArray);
                        break;
                    }

                }


            }

            return resultArray;
        }
    }
}
