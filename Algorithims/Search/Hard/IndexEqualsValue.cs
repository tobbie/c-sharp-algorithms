using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.Search.Hard
{
    public class IndexEqualsValue
    {
        public static int Find(int[]array)
        {
            if (array.Length == 0)
                return -1;

            return IndexEqualsValueHelper(array, 0, array.Length - 1);
        }

        private static int IndexEqualsValueHelper(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
                return -1;

            int middleIndex = (leftIndex + rightIndex) / 2;
            int middleValue = array[middleIndex];

            if (middleValue < middleIndex)
                return IndexEqualsValueHelper(array, middleIndex + 1, rightIndex);
            else if (middleValue == middleIndex && middleIndex == 0)
                return middleIndex;
            else if (middleValue == middleIndex && array[middleIndex - 1] < middleIndex - 1)
                return middleIndex;
            else
                return IndexEqualsValueHelper(array, leftIndex, middleIndex - 1);
        }
    }
}
