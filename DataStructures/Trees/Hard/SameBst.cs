using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees.Hard
{
    public class SameBst
    {
        public static bool IsSameBst(List<int> arrayOne, List<int>arrayTwo)
        {
            if (arrayOne.Count != arrayTwo.Count) 
                return false;

            if (arrayOne.Count == 0 && arrayTwo.Count == 0) 
                return true;
            if (arrayOne[0] != arrayTwo[0])
                return false;

            var leftOne = GetSmaller(arrayOne);
            var leftTwo = GetSmaller(arrayTwo);
            var rightOne = GetBigger(arrayOne);
            var rightTwo = GetBigger(arrayTwo);

            return IsSameBst(leftOne, leftTwo) && IsSameBst(rightOne, rightTwo);

        }

       private static List<int> GetSmaller(List<int> array)
        {
            var result = new List<int>();
            for (int i = 1; i < array.Count; i++)
            {
                if (array[i] < array[0])
                    result.Add(array[i]);
            }
            return result;
        }

        private static List<int> GetBigger(List<int> array)
        {
            var result = new List<int>();
            for (int i = 1; i < array.Count; i++)
            {
                if (array[i] >= array[0])
                    result.Add(array[i]);
            }
            return result;
        }

    }
}
