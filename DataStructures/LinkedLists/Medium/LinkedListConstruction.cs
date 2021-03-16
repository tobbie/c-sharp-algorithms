using System;
namespace DataStructures.LinkedLists.Medium
{
    public class LinkedListConstruction
    {

		public class DoublyLinkedList
		{
			public Node Head;
			public Node Tail;

			public void SetHead(Node node)
			{
				// Write your code here.
				InsertBefore(this.Head, node);
			}

			public void SetTail(Node node)
			{
				InsertAfter(this.Tail, node);
			}

			public void InsertBefore(Node node, Node nodeToInsert)
			{				
				// Write your code here.
				if (node == null){
					Head = nodeToInsert;
					Tail = Head;

				} else if(node.Prev != null) {

				}
				else if(node.Prev == null) {
					node.Prev = nodeToInsert;
					nodeToInsert.Next = node;
					Head = nodeToInsert;
				}
			}

			public void InsertAfter(Node node, Node nodeToInsert)
			{
				if (node == null){
					Tail = nodeToInsert;
					Head = Tail;
				}
				else if (node.Next != null) {

					//handle use case of when node is not the tail.
				}
				else if(node.Next == null) {
					node.Next = nodeToInsert;
					nodeToInsert.Prev = node;
					Tail = nodeToInsert;  // YOU have to finally point the tail reference!!!
				}
			}

			public void InsertAtPosition(int position, Node nodeToInsert)
			{
				// Write your code here.
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

			//not useful now.
			private void HandleNullNode(Node node) {
				if (node == null) {
					this.Head = node;
					this.Tail = this.Head;
					return;
				}												
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


  
}
