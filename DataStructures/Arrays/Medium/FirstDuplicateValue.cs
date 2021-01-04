using System;
using System.Collections.Generic;
using static System.Console;

namespace DataStructures.Arrays.Medium
{
    public static class FirstDuplicateValue
    {      

        public static void Run() {
            int[] array = new int[] { 2, 1, 5, 3, 3, 2, 4 };

            WriteLine($"First Duplicate is :{OptimalSolution(array)}");
        }

        private static int OptimalSolution(int [] array) {

            var hashSet = new HashSet<int>();

            foreach (var item in array)
            {
                if (hashSet.Contains(item))
                    return item;
                else
                    hashSet.Add(item);
            }

            return -1;
        }
    }
}
