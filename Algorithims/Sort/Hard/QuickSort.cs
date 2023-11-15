using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Algorithms.Sort.Hard
{
    public class QuickSort
    {
        public static int[] Sort(int[] array)
        {
            quickSortHelper(array, 0, array.Length -1);
            return array;
        }

        // [6, 5, 8, 7 , 9, 10, 1 , 4, 3, 2]
        //  P   L                         R

        private static void quickSortHelper(int[] array, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
                return;

            int pivotIndex = startIndex;
            int leftIndex = startIndex + 1;
            int rightIndex = endIndex;

            while(rightIndex >= leftIndex)
            {
                if (array[leftIndex] > array[pivotIndex] && array[rightIndex] < array[pivotIndex])
                    Util.Swap(array, leftIndex, rightIndex);

                if (array[leftIndex] <= array[pivotIndex])
                    leftIndex++;

                if (array[rightIndex] >= array[pivotIndex])
                    rightIndex--;

            }

            Util.Swap(array, pivotIndex, rightIndex);

            bool leftIsSmallerSubArray = (rightIndex - 1) - startIndex < endIndex - (rightIndex + 1);

            //always perform quick sort on smallest subarray first
            if(leftIsSmallerSubArray)
            {
                quickSortHelper(array, startIndex, rightIndex - 1);
                quickSortHelper(array, rightIndex + 1, endIndex);
            }
            else
            {
                quickSortHelper(array, rightIndex + 1, endIndex);
                quickSortHelper(array, startIndex, rightIndex - 1);
            }
        }
    }
}
