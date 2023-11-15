using System;


namespace Algorithms.Search.Easy
{
  public class BinarySearch
    {
        public static int Find(int [] array, int target)
        {
            if (array.Length == 0)
                return -1;

            if (array.Length == 1)
                return array[0];

            int leftPointer = 0;
            int rightPointer = array.Length - 1;

            while(leftPointer <= rightPointer)
            {
              int middleIndex =(int) Math.Floor((leftPointer + rightPointer) / 2m);

                if (array[middleIndex] > target)
                    rightPointer = middleIndex - 1;
                else if (array[middleIndex] < target)
                    leftPointer = middleIndex + 1;
                else
                    return middleIndex;
                
            }

            return -1;
        }
    }
}
