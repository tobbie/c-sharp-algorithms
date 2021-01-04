using System;
using System.Collections.Generic;
using static System.Console;

namespace DataStructures
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

        }



        public static void Print2DArray<T>(List<List<T>>list)
        {

            WriteLine("[");
            foreach (var item in list)
            {
                Write("[");
                foreach (var value in item)
                {               
                   Write($"{value}, ");
                }         
                Write("],");
            }
            WriteLine("\n]");
        }


    }

    
}
