using System;
using System.Collections.Generic;

namespace DataStructures.LinkedLists.Medium
{
    public class SumOfLinkedList
    {
        public LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
        {
            int carry = 0; LinkedList head = null; int counter = 0; LinkedList lastNode = null;

            while (linkedListOne != null || linkedListTwo != null)
            {
                int firstValue = linkedListOne != null ? linkedListOne.value : 0;
                int secondValue = linkedListTwo != null ? linkedListTwo.value : 0;

                int sum = firstValue + secondValue + carry;
                if (sum >= 10)
                {
                    sum = sum - 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }


                BuildResultList(ref head, ref lastNode, counter, sum);
/**
                if(counter == 0)
                {
                    head = new LinkedList(sum);
                    lastNode = head;
                }
                else
                {
                    var newNode = new LinkedList(sum);
                    lastNode.next = newNode;
                    lastNode = newNode;
                    
                }
**/
                counter++;
                linkedListOne = linkedListOne!= null ? linkedListOne.next : null;
                linkedListTwo =  linkedListTwo!= null ? linkedListTwo.next : null;
            }

            if (carry == 1) {
                BuildResultList(ref head, ref lastNode, counter, carry);
            }


            return head;
        }

        private void BuildResultList(ref LinkedList head, ref LinkedList lastNode, int counter, int sum){

            if (counter == 0)
            {
                head = new LinkedList(sum);
                lastNode = head;
            }
            else
            {
                var newNode = new LinkedList(sum);
                lastNode.next = newNode;
                lastNode = newNode;
            }
        }
    }


    // This is an input class. Do not edit.
    public class LinkedList
    {
        public int value;
        public LinkedList next;

        public LinkedList(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
