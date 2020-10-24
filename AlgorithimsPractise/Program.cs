using System;
using System.Collections;
using Arrays;

namespace AlgorithimsPractise
{
	class Program
	{
		static void Main(string[] args)
		{


			//ValidateSubSequence.Run();
			ThreeNumberSumTest.Run();


			/**
			int[] array = { 3, 5, -4, 8, 11, 1, -1, 6 };
			int targetSum = 10;

			var result = TwoNumberSum3(array, targetSum);
			if (result.Length > 0)
			{
				Console.WriteLine($"The two number sum for {targetSum} are [{result[0]} , {result[1]} ]");
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine($"No two elements in array sum up to {targetSum} ");
				Console.ReadLine();
			}
         **/

		}

		public static int[] TwoNumberSum(int[] array, int targetSum)
		{
			// Write your code here.
			int counter = 0;
			int[] result = new int[2];
			while (counter < (array.Length - 1))
			{

				for (int index = counter + 1; index < array.Length; index++)
				{
					int firstNumber = array[counter];
					int secondNumber = array[index];
					int sum = firstNumber + secondNumber;
					if (sum == targetSum)
					{
						result[0] = firstNumber;
						result[1] = secondNumber;
						return result;
					}

				}
				counter++;
			}

			return result;

		}

		public static int[] TwoNumberSum2(int[] array, int targetSum)
		{
			int counter = 0;
			int[] result = new int[2];

			while (counter < (array.Length - 1))
			{
				int searchValue = targetSum - array[counter];

				for (int index = counter + 1; index < array.Length; index++)
				{

					if (searchValue == array[index])
					{
						result[0] = array[counter];
						result[1] = searchValue;
						return result;
					}
				}

				counter++;
			}

			return new int[0];
		}

		public static int[] TwoNumberSum3(int[] array, int targetSum)
		{
			Hashtable ht = new Hashtable();
            foreach (var item in array)
            {
				ht.Add(item, item);
            }

			int counter = 0;
			int[] result = new int[2];

			while (counter < array.Length) {
				int searchValue = targetSum - array[counter];

				if (searchValue == array[counter]) {
					counter++;
					continue;
				}

				if (ht.ContainsValue(searchValue)) {
					result[0] = array[counter];
					result[1] = searchValue;
					return result;
				}
				counter++;
			}

			return new int[0];

		}
	}
}
