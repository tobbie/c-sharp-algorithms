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

        public static void Print2D<T>(T[,] array)
        {

            WriteLine("[");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Write("[");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Write($"{ array[i, j]}, ");

                }
                WriteLine("]");
               


            }
            WriteLine("\n]");

            ReadLine();
        }

        public static void Swap<T>(T[] array, int left, int right)
        {
            T temp = array[left];
            array[left] = array[right];
            array[right] = temp;

        }

        public static void Swap2<T>(T[] array, int left, int right)
        {
            while(left < right)
            {
                T temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;

            }

        }


        public static Dictionary<int, List<int>> BuildGraph(int number, int[][] array)
        {
            var graph = new Dictionary<int, List<int>>();

            for (int i = 0; i < number; i++)
                graph.Add(i, new List<int>());

            foreach (var item in array)     
                graph[item[0]].Add(item[1]);
           
            return graph;
           
        }


    }


}
