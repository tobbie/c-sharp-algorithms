using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists.Medium
{
    public class CopyListWithRamdomPointer
    {
        private static ListNode2 Copy(ListNode2 head)
        {
            /**
            1. iterate over original list
            2. make copy of original not by creating new node
            3. map original node with copy node using dictionary, *Take account of next pointers and random pointers to null values*
            4. iterate over original list again
            5. set next pointer and random pointer of copy node to corresponding next pointers and random pointer of original node as keys
             **/

            if (head == null)
                return null;

            var currentNode = head;
            var oldNodeToCopyMap = new Dictionary<ListNode2, ListNode2>();
            
           
            while(currentNode != null)
            {
                var copy = new ListNode2(currentNode.val);
                oldNodeToCopyMap.Add(currentNode, copy);
                currentNode = currentNode.next;
            }

            currentNode = head;
            while(currentNode != null)
            {
                var copy = oldNodeToCopyMap[currentNode];
                copy.next =   currentNode.next != null  ? oldNodeToCopyMap[currentNode.next] : null;
                copy.random = currentNode.random != null ? oldNodeToCopyMap[currentNode.random] : null; ;
                currentNode = currentNode.next;
            }

            return oldNodeToCopyMap[head];
        }
    }

    public class ListNode2
    {
        public int val;
        public ListNode2 next;
        public ListNode2 random;

        public ListNode2(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}
