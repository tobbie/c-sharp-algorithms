using System;
using System.Collections.Generic;

namespace DataStructures.LinkedLists.Easy
{
    public class RemoveDuplicates
    {
		//linkedList = 1 -> 1 ->3 -> 4 ->4 -> 4 ->5 -> 6 ->6 
		public class LinkedList
		{
			public int value;
			public LinkedList next;

			public LinkedList(int value)
			{
				this.value = value;
				this.next = null;
			}
		}

		public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
		{
			// Write your code here.
			if (linkedList == null)
				return null;

			var currentNode = linkedList;
			var nextNode = currentNode.next == null? currentNode : currentNode.next; 

			while (currentNode.next != null) {
				if (currentNode.value != nextNode.value)
				{
					currentNode = nextNode;
					nextNode = currentNode.next;
				}
				else {
					currentNode.next = nextNode.next;
					nextNode = currentNode.next;
				}				
			}
			return linkedList;
		}
	}
}
