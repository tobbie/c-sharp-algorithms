using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Arrays.Hard
{
    public class LongestRange
    {
        public LongestRange()
        {
        }

        public static void Run()
        {
            var array = new int[] {1, 11, 3, 0, 15,15, 5, 2, 4, 10, 7, 12, 6 };
            Util.PrintList(OptimalSolution(array).ToList());
            
        }

        private static int[] OptimalSolution(int[] array)
        {
            var resultRange = new List<int>();
            int rangeLength = -1;
            var arrayDict = new Dictionary<int, bool>();

            //create dict (hashtable) from input array
            for (int index = 0; index < array.Length; index++) {

                if(!arrayDict.ContainsKey(array[index])) // handle the edge case of duplicates in the array
                      arrayDict.Add(array[index], true);

            }
               



            for (int index = 0; index < array.Length; index++)
            {
                int rightValue = array[index];
                int leftValue = rightValue - 1;
                var tempRangeList = new HashSet<int>();

                while (arrayDict.ContainsKey(leftValue) && arrayDict[leftValue] == true)
                {
                    arrayDict[leftValue]= false;
                    tempRangeList.Add(leftValue);
                    leftValue--;

                }

                while (arrayDict.ContainsKey(rightValue) && arrayDict[rightValue]== true)
                {
                    arrayDict[rightValue] = false;
                    tempRangeList.Add(rightValue);
                    rightValue++;

                }

                if (tempRangeList.Count > rangeLength)
                {
                    var computedRange = new List<int>();
                    computedRange.Add(tempRangeList.Min());
                    computedRange.Add(tempRangeList.Max());
                    resultRange = computedRange;
                    rangeLength = tempRangeList.Count;
                }

            }

            return resultRange.ToArray();
        }
    }
}
