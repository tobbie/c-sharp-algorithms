using System;
using static System.Console;

namespace Algorithims.Recursion
{
    public static class RecursionDemo
    {
        private static int _counter = 0;

        public static void Run() {
            Inception();
        }


        /**

        1. Identify the base case(s)
        2. Identify the recrusive case
        3. Get closer and closer to and return when needed. Usually you have 2 returns
        4. Use memoization to achieve better results
        **/


        private static string Inception() {
            WriteLine(_counter);

            if (_counter > 3)
                return "done";
            _counter++;
           return Inception();

        }
    }
}
