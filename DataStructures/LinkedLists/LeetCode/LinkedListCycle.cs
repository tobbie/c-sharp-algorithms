using System;
namespace DataStructures.LinkedLists.LeetCode
{
    public class LinkedListCycle
    {
        public static LinkedList FindLoop(LinkedList head)
        {
            // intialise first pointer to next node from the head, second pointer to two nodes from the head
            var first = head.next != null? head.next : null;
            if (first is null)
                return null;

            var second = head.next.next != null ? head.next.next : null;
            if (second is null)
                return null;

            //move thru singly linked list until first and second pointer overlap (point to the same node in the loop)
            while (first != second)
            {
                first = first.next != null? first.next: null;
                if (first == null)
                    return null;

                second = second.next!= null? second.next.next : null;
                if (second == null)
                    return null;

            }

            // move first or second pointer to the head.
            first = head;

            while (first != second)
            {
                first = first.next;
                second = second.next;
            }

            //when first pointer overlaps with second pointer again,
            //we are at the origin of the loop second pointer and

            return first;
        }
    }

    public class LinkedList
    {
        public int value;
        public LinkedList next = null;

        public LinkedList(int value)
        {
            this.value = value;
        }
    }
}
