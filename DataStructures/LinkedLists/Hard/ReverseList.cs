using System;
namespace DataStructures.LinkedLists.Hard
{
    public class ReverseList
    {
        // 0 --> 1 --> 2 --> 3 --> 4 --> 5

        // 5 --> 4 --> 3 --> 2 --> 1 --> 0

        public static LinkedList ReverseLinkedList(LinkedList head)
        {
            // Write your code here.
            LinkedList previousNode = null;
            LinkedList currentNode = head;

            while (currentNode != null) {
                LinkedList nextNode = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;

            }
            return previousNode;
        }
    }

   
}
