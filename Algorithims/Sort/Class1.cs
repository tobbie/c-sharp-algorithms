using System;
using static System.Console;

namespace Algorithims.Sort
{
    public static class Test
    {
        public static void RunSort() {
            char[] array = new char[] { 'd', 'f', 'c', 'a', 'k', 'b' };
            int[] intArray = new int[] { 2, 65, 34, 2, 1, 7, 8, 16 };
            
            Array.Sort(array);
            Array.Sort(intArray);

            foreach (var item in array)
            {
                Write($"{item},");
            }
            WriteLine();
            foreach (var item in intArray)
            {
                Write($"{item},");
            }

            ReadLine();
        }
    }
}
