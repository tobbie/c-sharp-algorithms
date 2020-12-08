using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace DataStructures.Easy
{
    public class TwoNumberSumTest
    {
        public TwoNumberSumTest()
        {

        }

		public static void Run()
		{
			
			int[] array = { 3, 5, -4, 8, 11, 1, -1, 6 };
			int targetSum = 10;

			var result = OptimalSolution(array, targetSum);
			if (result.Length > 0)
			{
				WriteLine($"The two number sum for {targetSum} are [{result[0]} , {result[1]} ]");
				ReadLine();
			}
			else
			{
				WriteLine($"No two elements in array sum up to {targetSum} ");
				ReadLine();
			}
        
		}

		public static int[] OptimalSolution(int[] array, int targetSum)
		{

			int[] result = new int[2];
			var hashTable = new HashSet<int>();
			

		
			
			
			int index = 0;
			while (index < array.Length)
			{

				int secondNumber = targetSum - array[index];

				if (hashTable.Contains(secondNumber))
				{
					result[0] = array[index];
					result[1] = secondNumber;
					return result;
				}
				else
					hashTable.Add(array[index]);

				index++;
			}

			return new int[0];

		}


		private static int[] TwoNumberSum(int[] array, int targetSum)
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

		private static int[] TwoNumberSum2(int[] array, int targetSum)
		{
			Hashtable ht = new Hashtable();
			foreach (var item in array)
			{
				ht.Add(item, item);
			}

			int counter = 0;
			int[] result = new int[2];

			while (counter < array.Length)
			{
				int searchValue = targetSum - array[counter];

				if (searchValue == array[counter])
				{
					counter++;
					continue;
				}

				if (ht.ContainsValue(searchValue))
				{
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
