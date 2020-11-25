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


    }

    
}
