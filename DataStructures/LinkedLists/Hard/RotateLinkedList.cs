using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists.Hard
{
  public class RotateLinkedList
    {
        //O(n) , O(1)
        public static ListNode Rotate(ListNode head, int k)
        {
            var originalTail = head;
            int Length = 1;

            while (originalTail.Next != null)
            {
                originalTail = originalTail.Next;
                Length += 1;
            }

            int offset = Math.Abs(k) % Length;
            if (offset == 0)
                return head;

            int newTailPosition = k > 0 ? Length - offset : offset;
            ListNode newTail = head;

            for (int i = 1; i < newTailPosition; i++)
            {
                newTail = newTail.Next;
            }

            //do rotation
            var newHead = newTail.Next;
            originalTail.Next = head;
            newTail.Next = null;
            return newHead;
        }
    }
}
