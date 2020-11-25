using System;
using System.Linq;
namespace DataStructures.Arrays.HackerRank
{
    public static class ReverseIntegerArray
    {

        public static void Run() {
            var testArray = new int[] { 1, 4, 3, 2 };

            Util.PrintList(ReverseArray(testArray).ToList());
        }

        public static int[] ReverseArray(int[] array) {
            int startPointer = 0;
            int endPointer = array.Length - 1;

            while (startPointer < endPointer) {
                int temp = array[startPointer];
                array[startPointer] = array[endPointer];
                array[endPointer] = temp;
                startPointer++;
                endPointer--;
            }

            return array;
        }
    }
}
