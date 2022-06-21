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
                linkedListOne = linkedListOne != null ? linkedListOne.next : null;
                linkedListTwo = linkedListTwo != null ? linkedListTwo.next : null;
            }

            if (carry == 1) {
                BuildResultList(ref head, ref lastNode, counter, carry);
            }


            return head;
        }

        private void BuildResultList(ref LinkedList head, ref LinkedList lastNode, int counter, int sum) {

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

        //O(Max(m, n)) time , O(Max(m,n)) space
        public LinkedList Sum(LinkedList linkedListOne, LinkedList linkedListTwo)
        {
            var nodeHeadPointer = new LinkedList(0);
            var currentNode = nodeHeadPointer;
            int carry = 0;

            var nodeOne = linkedListOne;
            var nodeTwo = linkedListTwo;

            while (nodeOne != null || nodeTwo != null || carry != 1)
            {
                int valueOne = nodeOne != null ? nodeOne.value : 0;
                int valueTwo = nodeTwo != null ? nodeTwo.value : 0;

                int sum = valueOne + valueTwo + carry;
                int nodeValue = sum % 10;

                var newNode = new LinkedList(nodeValue);
                currentNode.next = newNode;
                currentNode = newNode;

                carry = sum / 10;

                nodeOne = nodeOne != null ? nodeOne.next : null;
                nodeTwo = nodeTwo != null ? nodeTwo.next : null;
            }

            return nodeHeadPointer.next;
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
