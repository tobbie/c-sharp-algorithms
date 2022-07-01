using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists.Hard
{
    public class MergeLinkedLists
    {
        public static ListNode Merge(ListNode headOne, ListNode headTwo)
        {
            //h1 = 2 -> 6 -> 7 -> 8;
            //h2 = 1 -> 3 -> 4 -> 5 -> 9 -> 10

            var p1 = headOne;
            var p2 = headTwo;

            ListNode previous = null;

            while(p1 != null && p2 != null)
            {
                if(p1.Value < p2.Value)
                {
                    previous = p1;
                    p1 = p1.Next;
                }
                else
                {
                    if (previous is not null)
                        previous.Next = p2;
                    previous = p2;
                    p2 = p2.Next;
                    previous.Next = p1;
                }
            }

            if (p1 is null)
                previous.Next = p2;

            return headOne.Value < headTwo.Value ? headOne : headTwo;
        }

        public static ListNode MergeKLists(ListNode[] lists)
        {
            var resultList = lists[0];

            for (int i = 1; i < lists.Length; i++)
            {
                resultList = Merge(resultList, lists[i]);
            }

            return resultList;
        }
    }

   
}
