using static System.Console;
using DataStructures.Strings.LeetCode;
using Algorithims.Recursion;
using DataStructures.Arrays.LeetCode;
using Algorithims.Recursion.Medium;
using DataStructures.LinkedLists.Medium;

namespace AlgorithimsPractise
{
	class Program
	{
		static void Main(string[] args)
		{
			var node1 = new Node(1);
			
			var ddList = new DoublyLinkedList();

			ddList.SetHead(node1);

			for (int i = 5; i >= 2; i--) {
				var node = new Node(i);
				ddList.InsertAfter(ddList.Head, node);
			}

			var currentNode = ddList.Head;
			while (currentNode is not null) {
				Write($"<< {currentNode.Value} >>");
				currentNode = currentNode.Next;
			}
			//Mnemonics.Run();
			//PowerSet.Run();

			//Permutation.Run();
			//ProductSum.Run();


			//Factorial.Run();
			// RunLengthEncoding.Run();
			//GroupAnagrams.Run();
			//ValidAnagram.Run();
			//RecursionDemo.Run();
			//Fibonacci.Run();
			//LongestPalindromicSubstring.Run();

			//FirstDuplicateValue.Run();
			//ValidPalindrome.Run();		
		}
	

		
	}
}
