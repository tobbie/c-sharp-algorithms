using System;
using System.Collections.Generic;
using static System.Console;

namespace DataStructures.Medium
{
    public class MoveElementToEndPractice
    {
        public MoveElementToEndPractice()
        {
        }

        public static void Run() {

            var inputArray = new List<int>{ 2, 1, 2, 2, 2, 3, 4, 2 };
            int toMove = 2;

            var resultArray = MoveElementToEnd(inputArray, toMove);
            int startIndex = 0;

            Write("[");
            while (startIndex < resultArray.Count) {
              
                Write($"'{resultArray[startIndex]}', ");
                startIndex++;
            }

            Write("]");
            WriteLine();
            ReadLine();
        }

        public static List<int> MoveElementToEnd(List<int> inputArray, int toMove)
        {
            int leftPointer = 0;
            int rightPointer = inputArray.Count - 1;
            int numberOfOperations = 0;

            while (leftPointer < rightPointer) {

                if (inputArray[rightPointer] == toMove)
                    rightPointer--;

                if (inputArray[leftPointer] != toMove)
                    leftPointer++;

                if ((inputArray[rightPointer] != toMove) & (inputArray[leftPointer] == toMove)) {
                    inputArray[leftPointer] = inputArray[rightPointer];
                    inputArray[rightPointer] = toMove;
                }

                numberOfOperations++;
                
            }

            return inputArray;
        }
    }
}
