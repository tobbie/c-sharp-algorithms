using System;
using Common;

namespace Algorithims.Search.Hard
{
    public class QuickSelect
    {
        //O(n) time , O(1) space
        public static int Find(int[] array, int k)
        {
            int position = k - 1;
            return QuickSortHelper(array, 0, array.Length - 1, position);
        }

        private static int QuickSortHelper(int[] array, int startIndex, int endIndex, int position)
        {
            while (true)
            {
                if (startIndex > endIndex)
                    throw new Exception("something is terribly wrong");
               
                int pivot = startIndex;
                int leftIndex = startIndex + 1;
                int rightIndex = endIndex;

                while(leftIndex <= rightIndex)
                {
                    if (array[leftIndex] > array[pivot] &&  array[rightIndex] < array[pivot])
                        Util.Swap(array, leftIndex, rightIndex);

                    if (array[leftIndex] <= array[pivot])
                        leftIndex += 1;

                    if (array[rightIndex] >= array[pivot])
                        rightIndex -= 1;

                }
                Util.Swap(array, pivot, rightIndex);

                if (rightIndex == position)
                    return array[rightIndex];
                else if (rightIndex > position)
                    endIndex = rightIndex - 1;
                else
                    startIndex = rightIndex + 1;
            }
           
        }
    }
}
