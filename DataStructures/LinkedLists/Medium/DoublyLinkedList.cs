using System;
namespace DataStructures.LinkedLists.Medium
{
    public class DoublyLinkedList
    {
		public Node Head { get; private set; }
		public Node Tail { get; private set; }
		public int Length { get; private set; }

		public void SetHead(Node node)
		{
			if (Head is null) {
				Head = node;
				Tail = node;
				Length++;
				return;
			}

			InsertBefore(Head, node);
		}

		public void SetTail(Node node)
		{
			if (Tail is null) {
				SetHead(node);
				return;
			}
			InsertAfter(Tail, node);
		}

		public void InsertBefore(Node node, Node nodeToInsert)
		{
			if (nodeToInsert == Head && nodeToInsert == Tail)
				return;

			Remove(nodeToInsert);
			nodeToInsert.Prev = node.Prev;
			nodeToInsert.Next = node;

			if (node.Prev is null)
				Head = nodeToInsert;
			else
				node.Prev.Next = nodeToInsert;

			node.Prev = nodeToInsert;
			Length++;
		}

		public void InsertAfter(Node node, Node nodeToInsert)
		{
			if (nodeToInsert == Head && nodeToInsert == Tail)
				return;

			Remove(nodeToInsert);

			nodeToInsert.Prev = node;
			nodeToInsert.Next = node.Next;

			if (node.Next is null)
				Tail = nodeToInsert;
			else
				node.Next.Prev = nodeToInsert;

			node.Next = nodeToInsert;
			Length++;
		}

		public void InsertAtPosition(int position, Node nodeToInsert)
		{
			if (position == 1) {
				SetHead(nodeToInsert);
				return;
			}

			var currentNode = Head;
			int currentPosition = 1;

			while (currentNode is not null & currentPosition != position){
				currentNode = currentNode.Next;
				currentPosition++;
			}

			if (currentNode is not null)
				InsertBefore(currentNode, nodeToInsert);
			else
				SetTail(nodeToInsert);
			
		}

		public void RemoveNodesWithValue(int value)
		{
			var node = Head;
			while (node is not null) {

				var nodeToRemove = node;
				node = node.Next;

				if (nodeToRemove.Value == value)
					Remove(nodeToRemove);		
			}
		}

		public void Remove(Node node)
		{
			if (node == Head)
				Head = Head.Next;

			if (node == Tail)
				Tail = Tail.Prev;

			RemoveNodeBindings(node);
			Length--;
		}

        private void RemoveNodeBindings(Node node)
        {
           if(node.Prev is not null)
				node.Prev.Next = node.Next;

			if (node.Next is not null)
				node.Next.Prev = node.Prev;

			node.Prev = null;
			node.Next = null;
        }

        public bool ContainsNodeWithValue(int value) {
			var currentNode = this.Head;
			while (currentNode is not null && currentNode.Value != value)
				currentNode = currentNode.Next;

			return currentNode != null;
		}

		public Node FindNode(int value) {
			var currentNode = this.Head;
			while (currentNode is not null && currentNode.Value != value)
				currentNode = currentNode.Next;

			return currentNode;
		}
    }


	// Do not edit the class below.
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
