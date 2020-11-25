using System;
using static System.Math;
namespace DataStructures.Medium
{
    public static class SmallestDifferencePractise
    {
        public static int[] Run(int[] array1, int[] array2)
        {
            throw new NotImplementedException();
        }

        public static int[] SmallestDifference(int[] array1, int[] array2) {

            int[] resultArray = new int[2];
            int pointer1 = 0, pointer2 = 0;
            //int currentAbsoluteValue = 0 , nextAbsoluteValue = 0;
            Array.Sort(array1);
            Array.Sort(array2);

            int nextAbsoluteValue = Abs(array1[pointer1] - array2[pointer2]);
            
            while (pointer1 < array1.Length & pointer2 < array2.Length) {

               int currentAbsoluteValue = Abs(array1[pointer1] - array2[pointer2]);

                if (currentAbsoluteValue == 0)
                {
                    resultArray[0] = array1[pointer1];
                    resultArray[1] = array2[pointer2];
                    return resultArray;
                }

                
                if (currentAbsoluteValue <= nextAbsoluteValue) {
                    nextAbsoluteValue = currentAbsoluteValue;
                    resultArray[0] = array1[pointer1];
                    resultArray[1] = array2[pointer2];
                }

                if (array1[pointer1] < array2[pointer2])
                {
                    pointer1++;
                }
                else {
                    pointer2++;
                }
             
            }

            return resultArray;
        }
    }
}
