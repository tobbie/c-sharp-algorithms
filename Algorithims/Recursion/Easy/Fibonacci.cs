using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using static System.Console;

namespace Algorithims.Recursion.Easy
{
	public static class Fibonacci
	{
		public static void Run() {
			
			while (true)
			{
				Write("Find fibonacci: ");
				var sw = new Stopwatch();
				int number = int.Parse(ReadLine());
				sw.Start();
				//Thread.Sleep(1);
				WriteLine($"Fibonacci is : {FibBottomUp(number)}");


				WriteLine();
				sw.Stop();
				WriteLine($"Time elapsed: {sw.ElapsedMilliseconds / 1000} seconds, {sw.ElapsedMilliseconds} milliseconds, {sw.Elapsed}");
				WriteLine();
			}
			
		}

		//O(2^n) time O(n) space
		private static long GetNthFib(int n) {
			// Write your code here.

			if (n <= 0)
				return 0;
			else if (n == 1  || n == 2)
				return 1;
			else 
				return GetNthFib(n - 1) + GetNthFib(n - 2);
		}


		//O(n) time O(n) space
		private static long OptimalRecusiveNthFib(int n)
		{
			if (n < 0)
				return -1;

			var memoizeDict = new Dictionary<int, long>();
			memoizeDict.Add(0, 0);
			memoizeDict.Add(1, 1);

			return GetNthFib(n, memoizeDict);

		}

        private static long GetNthFib(int n, Dictionary<int, long> memoizeDict)
        {
			if (memoizeDict.ContainsKey(n))
				return memoizeDict[n];
			else
			{
				memoizeDict.Add(n, GetNthFib(n - 1, memoizeDict) + GetNthFib(n - 2, memoizeDict));
				return memoizeDict[n];
			}			         
        }

		public static long Fib(int n) {
			var memo = new long?[n + 1];
			return GetFib(n, memo);
			
		}

		private static long GetFib(int n, long?[] memo) {
			long result;

			if (memo[n] != null)
				return (long)memo[n];

			if (n == 0)
			    result = 0;
			else if (n == 1 || n == 2)
				result = 1;
			else
				 result = GetFib(n - 1, memo) + GetFib(n - 2, memo);

			memo[n] = result;

			return result;

		}

		public static long FibBottomUp(int n) {
			if (n <= 0)
				return 0;
			else if (n == 1 || n == 2)
				return 1;

			var result = new long[n + 1];
			result[0] = 0;
			result[1] = 1;

			for (int index = 2; index < result.Length; index++)
				result[index] = result[index - 1] + result[index - 2];

			return result[n];

            
		}
    }
}
