using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using static System.Console;
using System.Numerics;
using Common;

namespace Algorithims.Recursion.Easy
{
    public static class Factorial
    {
        private static readonly Dictionary<int, long> Memo = new Dictionary<int, long>();
       
        
        public static void Run()
        {
            // Fix infinite loop problem - exit code after 5mins max
            WatchWrapper.Start(); 
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

                if (WatchWrapper.ElapsedTime / 2000 > WatchWrapper.MAX_TIME)
                {
                    WriteLine($"Ending loop and program...");
                    WatchWrapper.Stop();
                    break;
                }                 
            }
        }

        private static long GetFactorial(int number)
        {
            Memo.TryAdd(1, 1);
            return GetFactorial(number, Memo);
        }

        private static long GetFactorial(int number, Dictionary<int, long> memo)
        {
            if (memo.ContainsKey(number))
                return memo[number];
            else
            {
                memo.Add(number,  number * GetFactorial(number - 1, memo));
                return memo[number];
            }
        }

        private static long GetFactorial2(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * GetFactorial2(number - 1);
        }

        public static BigInteger GetFactorialIterative(int number)
        {
            if (number < 1)
                number = Math.Abs(number);

            if (number == 1 || number == 0)
                return 1;
            else
            {
                BigInteger result = 1;
                for (int index = 2; index <= number; index++)
                    result *= index;
                return result;
            }
            
           
        }
    }
}
