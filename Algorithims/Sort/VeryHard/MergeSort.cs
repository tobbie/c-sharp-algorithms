using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.Sort.VeryHard
{
    public  class MergeSort
    {
        public static int[] DoMergeSort( int[] array)
        {
            if (array.Length <= 1)
                return array;

            int middleIndex = array.Length / 2;
           

            var leftHalf = array[..middleIndex];
            var rightHalf = array[middleIndex..];

          //  var left = new int[middleIndex];
         //   var right = new int[array.Length - middleIndex];

         //   Array.Copy(array, 0, left, 0, middleIndex);
          //  Array.Copy(array, middleIndex, right, 0, array.Length - middleIndex);

            var leftMerge = DoMergeSort(leftHalf);
            var rightMerge = DoMergeSort(rightHalf);
         
         
            return MergeSortedArrays(leftMerge, rightMerge);
        }

        private static int[] MergeSortedArrays(int[] leftHalf, int[] rightHalf)
        {
            var sortedArray = new int[leftHalf.Length + rightHalf.Length];
            int k, i, j;
            k = i = j = 0;

            while(i < leftHalf.Length && j < rightHalf.Length)
            {
                if(leftHalf[i] <= rightHalf[j])
                {
                    sortedArray[k] = leftHalf[i];
                    i++;
                }
                else
                {
                    sortedArray[k] = rightHalf[j];
                    j++;
                }
                k += 1;
            }

            while(i < leftHalf.Length)
            {
                sortedArray[k] = leftHalf[i];
                i++;
                k++;
            }

            while(j < rightHalf .Length)
            {
                sortedArray[k] = rightHalf[j];
                j++;
                k++;
            }
            return sortedArray;

        }
    }

   
}
