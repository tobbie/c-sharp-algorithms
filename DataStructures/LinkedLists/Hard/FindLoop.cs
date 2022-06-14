using System;
namespace DataStructures.LinkedLists.Hard
{
    public class FindLoopInLinkedList
    {
        // F = X = D + P, S = 2X = 2D + 2P; T = D + P + R
        public static ListNode FindLoop(ListNode head)
        {
            // intialise first pointer to next node from the head, second pointer to two nodes from the head
            var first = head.Next;
            var second = head.Next.Next;

            //move thru singly linked list until first and second pointer overlap (point to the same node in the loop)
            while (first != second) {
                first = first.Next;
                second = second.Next.Next;
            }

            // move first or second pointer to the head.
            first = head;

            while (first != second) {
                first = first.Next;
                second = second.Next;
            }

            //when first pointer overlaps with second pointer again,
            //we are at the origin of the loop second pointer and

            return first;
        }

        
    }

    public class SinglyLinkedList
    {
       

        public ListNode Head { get; private set; }
        public ListNode Tail { get; private set; }
       
        public void Add(ListNode node)
        { 
            if(Head == null)
            {
                Head = node;
                Tail = Head;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
                        
            
        }
    }

    public class ListNode
    {
        public int Value { get; private set; }
        public  ListNode Next { get; set; }

        public ListNode (int value)
        {
            Value = value;
        }
    }

    
}
