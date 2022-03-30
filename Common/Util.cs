using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

namespace Common
{ 
    public static class Util
    { 

        public static void PrintList<T>(IEnumerable<T> list) {

            Write("[");

            foreach (var item in list)
            {
                Write($"{item},");
            }

            Write("]");
            WriteLine();
        }

        public static void PrintValue<T>(T value){

            WriteLine();
            Write($"value is , {value.ToString()}");
            ReadLine();
        }

        public static void Print2DArray(List<int[]> list) {

        }

        public static void Print2DArray<T>(List<List<T>>list)
        {

            WriteLine("[");
            foreach (var array in list)
            {
                Write("[");
                foreach (var value in array)
                {
                 if (array.Last().Equals(value))
                        Write($"{value}");
                  else
                        Write($"{value}, ");
                   
                }

                if (list.Last().Equals(array))
                    Write("]");
                else
                    Write("],");
               

            }
            WriteLine("\n]");
        }


    }

    
}
