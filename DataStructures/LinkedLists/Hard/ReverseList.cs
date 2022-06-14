using System;
namespace DataStructures.LinkedLists.Hard
{
    public class ReverseList
    {
        // 0 --> 1 --> 2 --> 3 --> 4 --> 5

        // 5 --> 4 --> 3 --> 2 --> 1 --> 0

        public static ListNode ReverseLinkedList(ListNode head)
        {
            // Write your code here.
            ListNode previousNode = null;
            ListNode currentNode = head;

            while (currentNode != null) {
                ListNode nextNode = currentNode.Next;
                currentNode.Next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;

            }
            return previousNode;
        }
    }

   
}
