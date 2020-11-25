using System;
using System.Collections.Generic;
using static System.Console;

namespace DataStructures.LinkedLists
{
    public class DoublyLinkedList
    {
        public Node Head;
        public Node Tail;
		public int Length;

		public DoublyLinkedList(Node node) {
			this.Head = node;
			this.Tail = this.Head;
			this.Length = 1;

		}
		public void SetHead(Node node)
		{
			// Write your code here.
			var prevHead = this.Head;
			prevHead.Prev = node;
		
			node.Next = prevHead;
			this.Head = node;
			this.Length++;
			
			
		}

		public void SetTail(Node node)
		{
			// Write your code here.
			var prevTail = this.Tail;
			prevTail.Next = node;
			node.Prev = prevTail;
			this.Tail = node;
			this.Length++;
		}

		public void InsertBefore(Node node, Node nodeToInsert)
		{
			Node previousNode = null;
			Node nextNode = null;


			// Write your code here.
		}

		public void InsertAfter(Node node, Node nodeToInsert)
		{
			// Write your code here.
		}

		public void InsertAtPosition(int position, Node nodeToInsert)
		{

			// Write your code here.
			if (position == 1) {
				SetHead(nodeToInsert);
				return;
			}

			Node currentNode = GetNodeAtPosition(position);
			var previousNode = currentNode.Prev;
			//var nextNode = currentNode.Next;
			previousNode.Next = nodeToInsert;
			currentNode.Prev = nodeToInsert;
			nodeToInsert.Prev = previousNode;
			nodeToInsert.Next = currentNode;
			return;
		}

		public void RemoveNodesWithValue(int value)
		{
			// Write your code here.
		}

		public void Remove(Node node)
		{
			// Write your code here.
		}

		public bool ContainsNodeWithValue(int value)
		{
			// Write your code here.
			return false;
		}

		private Node GetNode(int value) {

			var currentNode = this.Head;
			while (currentNode != null) {
				if (currentNode.Value == value)
				{
					return currentNode;
				}
				else {
					currentNode = currentNode.Next;
				}
			}

			return null;
		}

		private Node GetNodeAtPosition(int position) {
			if (position < 1 || position > this.Length)
				throw new InvalidOperationException();

			int currentPosition = 1;
			var nodeToFind = this.Head;
			if (position == currentPosition)
				return nodeToFind;

			while (currentPosition < this.Length) {
				currentPosition++;
				nodeToFind = nodeToFind.Next;
				if (currentPosition == position)
					return nodeToFind;			
			}

			return null;
		}

		public void PrintListValues() {

			var currentNode = this.Head;
			var result = new List<int>();
			while (currentNode != null) {

				result.Add(currentNode.Value);
				currentNode = currentNode.Next;
			}

			Write("[");
		
            foreach (var item in result)
            {
				
				Write($"{item},");
				
            }

			Write("]");
			WriteLine();
		}
	}

    public class Node
    {
        public int Value;
        public Node Prev;
        public Node Next;

        public Node(int value)
        {
            this.Value = value;
        }
    }
}
