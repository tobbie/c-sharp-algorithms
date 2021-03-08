using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using static System.Console;

namespace Algorithims.Recursion
{
    public static class Factorial
    {
        public static void Run()
        {

            while (true)
            {
                Write("Find factorial: ");
                var sw = new Stopwatch();
                int number = int.Parse(ReadLine());
                sw.Start();
                Thread.Sleep(1);
                WriteLine($"Facrtorial is : {GetFactorial(number)}");


                WriteLine();
                sw.Stop();
                WriteLine($"Time elapsed: {sw.ElapsedMilliseconds / 1000} seconds, {sw.ElapsedMilliseconds} milliseconds, {sw.Elapsed}");
                WriteLine();
            }
        }

        private static long GetFactorial(int number)
        {
            var memomizedDict = new Dictionary<int, long>();
            memomizedDict.Add(1, 1);
            return GetFactorial(number, memomizedDict);

        }

        private static long GetFactorial(int number, Dictionary<int, long> memomizedDict)
        {
            if (memomizedDict.ContainsKey(number))
                return memomizedDict[number];
            else
            {
                memomizedDict.Add(number, GetFactorial(number * (number - 1), memomizedDict));
                return memomizedDict[number];
            }
        }

        private static long GetFactorial2(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * GetFactorial2(number - 1);
        }
    }
}
