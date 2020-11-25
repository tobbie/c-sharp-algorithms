using System;
using static System.Console;
using System.Collections.Generic;
using System.Collections;

namespace Algorithims.Sort.Easy
{
    public static class SortType
    {
        public static void RunBubbleSort(){
            var numbers = new List<int> { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            int operationCount = 0;
            while (true) {
                int pointer1 = 0, sortCount = 0;
                int pointer2= 1;
               
                while ( (pointer1 < numbers.Count - 1) & (pointer2 < numbers.Count) ) {
                    int temp;
                    if (numbers[pointer1] > numbers[pointer2]) {
                        //swap
                        temp = numbers[pointer1];
                        numbers[pointer1] = numbers[pointer2];
                        numbers[pointer2] = temp;
                        sortCount++;
                    }
                    pointer1++;
                    pointer2++;
                }
                operationCount = operationCount + sortCount;
                if (sortCount == 0)
                    break;
            }
            WriteLine(operationCount);
            PrintSortedList(numbers);
        }

        private static void PrintSortedList<T>(T list) where T : IEnumerable { 

            foreach (var item in list)
            {
                Write($"{item}, ");
            }
            WriteLine();
            ReadLine();
        }

        public static void RunSelectionSort() {
            var numbers = new List<int> { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };

            for (int index = 0; index < numbers.Count; index++) {

                int pointerX = index, pointerY = index + 1, temp;
                while (pointerY < numbers.Count) {

                    if (numbers[pointerY] < numbers[pointerX]){
                        pointerX = pointerY;
                        pointerY++;
                    }
                    else
                        pointerY++;
                }
                //swap
                temp = numbers[index];
                numbers[index] = numbers[pointerX];
                numbers[pointerX] = temp;
            }
            WriteLine("Printing numbers sorted with selection sort");
            PrintSortedList(numbers);

        }
    }
}
