using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.Sort.VeryHard
{
    public  class CountInversions
    {
        public static int GetInversions(int[] array)
        {
            return DoMergeSort(array).CountInversions;
        }

        public static Inversions DoMergeSort(int[] array)
        {
            if (array.Length <= 1)
                return new Inversions(array);

            int middleIndex = array.Length / 2;


            var leftHalf = array[..middleIndex];
            var rightHalf = array[middleIndex..];

            var leftMerge = DoMergeSort(leftHalf);
            var rightMerge = DoMergeSort(rightHalf);
         
         
            var sortedArray = MergeSortedArrays(leftMerge.SortedArray, rightMerge.SortedArray, leftMerge.CountInversions + rightMerge.CountInversions);
            return sortedArray;
        }

        private static Inversions MergeSortedArrays(int[] leftHalf, int[] rightHalf, int countInversion)
        {
            var inversion = new Inversions(new int[leftHalf.Length + rightHalf.Length]);
            inversion.CountInversions = countInversion;
           // inversion.SortedArray = new int[leftHalf.Length + rightHalf.Length];
            int k, i, j;
            k = i = j = 0;

            while(i < leftHalf.Length && j < rightHalf.Length)
            {
                if(leftHalf[i] <= rightHalf[j])
                {
                    inversion.SortedArray[k] = leftHalf[i];
                    i++;
                }
                else
                {
                    inversion.SortedArray[k] = rightHalf[j];
                    inversion.CountInversions += leftHalf.Length - i;
                    j++;
                }
                k += 1;
            }

            while(i < leftHalf.Length)
            {
                inversion.SortedArray[k] = leftHalf[i];
                i++;
                k++;
            }

            while(j < rightHalf .Length)
            {
                inversion.SortedArray[k] = rightHalf[j];
                j++;
                k++;
            }
            return inversion; 

            
        }
    }

   public class Inversions
    {
        public Inversions(int[] array)
        {
            SortedArray = array;
        }
        public int [] SortedArray { get; private set; }
        public int  CountInversions { get; set; }
    }
}
