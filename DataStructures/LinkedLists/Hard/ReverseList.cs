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

        public static ListNode RecursiveReverse(ListNode head)
        {
            if (head == null || head.Next == null)
                return head;
            ListNode pointer1 = null;
            ListNode pointer2 = head;
            ListNode pointer3 = head;
            return ReverseHelper(pointer1, pointer2, pointer3);
        }

        private static ListNode ReverseHelper(ListNode pointer1, ListNode pointer2, ListNode pointer3)
        {
            if (pointer2 == null)
                return pointer1;

            pointer3 = pointer2.Next;
            pointer2.Next = pointer1;
            pointer1 = pointer2;
            pointer2 = pointer3;

            return ReverseHelper(pointer1, pointer2, pointer3);
        }
    }

   
}
