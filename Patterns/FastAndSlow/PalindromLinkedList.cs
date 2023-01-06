using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Patterns.FastAndSlow
{
   public class PalindromLinkedList
    {
        public bool IsPlaindrome(ListNode head)
        {
           var(previous, middle) = GetMiddle(head);

            var newMiddle = ReverseList(middle);

            previous!.next = newMiddle;

            var left = head;
            var right = newMiddle;

            while(left != newMiddle)
            {
                if (left.Value != right.Value)
                    return false;

                left = left.next;
                right = right.next;
            }

            return true;
        }

        private (ListNode?, ListNode) GetMiddle(ListNode node)
        {
            var slow = node;
            var fast = node;
            ListNode previous = null!;

            while(fast != null && fast.next != null)
            {
                previous = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            return (previous, slow); 
        }

        private ListNode ReverseList(ListNode start)
        {
            ListNode previous = null;
            ListNode current = start;
            ListNode next = current.next;

            while(next != null)
            {
                if (previous == null)
                    current.next = previous;
               
                previous = current;
                current = next;
                next = current.next;
                current.next = previous;

            }

            return current;
        }
    }
}
