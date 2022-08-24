

namespace MicrosoftInterview
{
    public class ReverseNodesInKGroup
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var dummyNode = new ListNode(0, head);
            var groupPrevious = dummyNode;

            while(true)
            {
                var kthNode = GetKthNode(groupPrevious, k);
                if (kthNode is null)
                    break;
                var groupNext = kthNode.next;

                //reverse group
                var previous = kthNode.next;
                var current = groupPrevious.next;

                while(current != groupNext)
                {
                    var temp = current.next;
                    current.next = previous;
                    previous = current;
                    current = temp;
                }

                var tmp = groupPrevious.next;
                groupPrevious.next = kthNode;
                groupPrevious = tmp;
            }
            return dummyNode.next;
        }

        private ListNode GetKthNode(ListNode current, int k)
        {
            while(current != null && k > 0)
            {
                current = current.next;
                k -= 1;
            }

            return current;
        }
    }

   
 // Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
        this.val = val;
         this.next = next;
      }
  }

}
