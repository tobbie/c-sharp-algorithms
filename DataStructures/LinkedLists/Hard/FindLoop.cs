using System;
namespace DataStructures.LinkedLists.Hard
{
    public class FindLoopInLinkedList
    {
        // F = X = D + P, S = 2X = 2D + 2P; T = D + P + R
        public static LinkedList FindLoop(LinkedList head)
        {
            // intialise first pointer to next node from the head, second pointer to two nodes from the head
            var first = head.next;
            var second = head.next.next;

            //move thru singly linked list until first and second pointer overlap (point to the same node in the loop)
            while (first != second) {
                first = first.next;
                second = second.next.next;
            }

            // move first or second pointer to the head.
            first = head;

            while (first != second) {
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
