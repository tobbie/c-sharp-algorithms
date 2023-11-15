using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search.Hard
{
   public class SearchForRange
    {
        public static int[] Find(int[] array, int target)
        {
            //[0, 1, 21, 33, 45, 45, 45, 45, 45, 45, 61, 71, 73]
            //  L                      M                       R
            if(array.Length == 0)
                return new int[] { -1, -1 };

            int left = 0;
            int right = array.Length - 1;
            int middle;
            
            while(left <= right)
            {
                 middle = (left + right) / 2;
                if (array[middle] < target)
                    left = middle + 1;
                else if (array[middle] > target)
                    right = middle  - 1 ;
                else
                    return GetTargetRange(array, middle, left, right, target);

            }

            return new int[] { -1, -1 };
        }

        private static int[] GetTargetRange(int[] array, int middle, int left, int right, int target)
        {
            int leftMostIndex = middle;
            int rightMostIndex = middle;
            

            while (leftMostIndex >= left && array[leftMostIndex] == target)
                leftMostIndex -= 1;

            while (rightMostIndex <= right && array[rightMostIndex] == target)
                rightMostIndex += 1;

            return new int[] { leftMostIndex + 1, rightMostIndex - 1 };
                    
        }

        public static int[] FindRecrusively(int[] array, int target)
        {
            var result = new int[] { -1, -1 };
            BinarySearchHelper(array, target, result, 0, array.Length - 1, true);
            BinarySearchHelper(array, target, result, 0, array.Length - 1, false);
            return result;
        }

        private static void BinarySearchHelper(int[] array, int target, int[] result, int left, int right, bool goLeft)
        {
            if (left > right)
                return;

            int middle = (left + right) / 2;

            if (target > array[middle])
            {
                left = middle + 1;
                BinarySearchHelper(array, target, result, left, right, goLeft);
            }         
            else if (target < array[middle])
            {
                right = middle - 1;
                BinarySearchHelper(array, target, result, left, right, goLeft);
            }         
            else
            {
                if(goLeft)
                {
                    if (middle == 0 || array[middle - 1] != target)
                    {
                        result[0] = middle;
                        return;
                    }
                    else
                    {
                        BinarySearchHelper(array, target, result, left, middle - 1, goLeft);
                    }                    
                }
                else
                {
                    if(middle == array.Length -1 || array[middle + 1] != target)
                    {
                        result[1] = middle;
                        return;
                    }
                    else
                    {
                        BinarySearchHelper(array, target, result, middle + 1, right, goLeft);
                    }
                }
            }
                
           
        }

        public static int[] FindIteratively(int[] array, int target)
        {
            var result = new int[] { -1, -1 };
            AlternateBinarySearch(array, target, result, 0, array.Length - 1, true);
            AlternateBinarySearch(array, target, result, 0, array.Length - 1, false);
            return result;
        }

        private static void AlternateBinarySearch(int[] array, int target, int[] result, int left, int right, bool goLeft)
        {
           while(left <= right)
           {
                int middle = (left + right) / 2;

                if (target > array[middle])
                    left = middle + 1;
                else if (target < array[middle])
                    right = middle - 1;
                else
                {
                    if(goLeft)
                    {
                        if (middle == 0 || array[middle - 1] != target)
                        {
                            result[0] = middle;
                            return;
                        }
                        else
                        {
                            right = middle - 1;
                        }
                    }
                    else
                    {
                        if (middle == array.Length - 1 || array[middle + 1] != target)
                        {
                            result[1] = middle;
                            return;
                        }
                        else
                        {
                            left = middle + 1;
                        }
                    }                 
                }    
                
           }
            return;
        }
    }
}
