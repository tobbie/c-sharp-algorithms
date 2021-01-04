using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Arrays.Easy
{
    public class TwoNumberIndices
    {
        public TwoNumberIndices()
        {
        }

        public static void Run()
        {
            var array = new int[] { 3, 2, 4 };
            Util.PrintList(OptimalSolution(array, 6).ToList());
        }

        private static int[] OptimalSolution(int[] array, int targetSum)
        {
            if (array.Length < 2)
                return new int[] { };

            var map = new Dictionary<int, int>();
            var result = new int[2];

            for (int index = 0; index < array.Length; index++)
            {
                int difference = targetSum - array[index];
                if (!map.ContainsKey(difference))
                    map.Add(array[index], index);
                else
                {
                    result[0] = map[difference];
                    result[1] = index;
                    return result;
                }

            }
            return result;

        }
    }
}
