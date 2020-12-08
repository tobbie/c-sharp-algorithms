using System;
using System.Collections.Generic;
using static System.Console;

namespace DataStructures.Arrays
{
    public static class Util
    { 

        public static void PrintList(List<int> list) {

            Write("[");

            foreach (var item in list)
            {
                Write($"{item},");
            }

            Write("]");
            WriteLine();
        }
        public static void PrintValue<T>(T value) {

            WriteLine();
            Write($"value is , {value.ToString()}");
            ReadLine();
        }

        public static void Print2DArray(List<int[]> list) {

            WriteLine("[");
            foreach (var item in list)
            {
                Write("  [");
                Write($"{item[0]}, ");
                Write($"{item[1]}, ");
                Write($"{item[2]}, ");
                Write($"{item[3]}, ");
                Write("], ");
            }
            WriteLine("\n]");
        }


    }

    
}
