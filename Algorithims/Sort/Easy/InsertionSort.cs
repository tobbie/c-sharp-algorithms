using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.Sort.Easy
{
    public class InsertionSort
    {
        public static int[] Sort(int [] array)
        {
            if(array.Length == 0) return new int[] { };
            if (array.Length == 1) return array;

            for (int index = 1; index < array.Length; index++)
            {
                int leftPointer = index - 1;
                int rightPointer = index;

                while(leftPointer >= 0 && array[leftPointer] > array[rightPointer])
                {
                    Swap(array, leftPointer, rightPointer);
                    leftPointer--;
                    rightPointer--;
                }
            }


            return array;
        }

        private static void Swap(int [] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
            
        }
    }
}
