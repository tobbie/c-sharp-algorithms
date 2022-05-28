using System;

namespace Algorithims.Search.Hard
{
    public class ShiftedBinarySearch
    {
        public static int Find(int[] array, int target)
        {
            return ShiftedBinarySearchHelper(array, 0, array.Length - 1, target);
        }
        // target = 33
        //[45, 61,71, 72, 73, 0, 1, 21, 33, 37]
        // L               M                 R
        //[61, 71, 72, 73, 0, 21, 33, 45, 45]
        // L               M               R
        private static int ShiftedBinarySearchHelper(int[] array,int left, int right, int target)
        {
            if (left > right)
                return -1;

            int middle = (left + right) / 2;
            var potentialMatch = array[middle];
            var leftNum = array[left];
            var rightNum = array[right];
           
            if (potentialMatch == target)
                return middle;
            else if(leftNum <= potentialMatch)
            {
                if (target >= leftNum && target < potentialMatch)
                    return ShiftedBinarySearchHelper(array, left, middle - 1, target);
                else
                    return ShiftedBinarySearchHelper(array, middle + 1, right, target);

            }
            else
            {
                if (target > potentialMatch && target <= rightNum)
                    return ShiftedBinarySearchHelper(array, middle + 1, right, target);
                else
                    return ShiftedBinarySearchHelper(array, left, middle - 1, target);
            }
        }
    }
}
