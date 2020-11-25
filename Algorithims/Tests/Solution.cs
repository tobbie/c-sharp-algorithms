using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithims.Tests
{
    public static class Solution
    {
       
        public static int TestRun(List<int> blocks, int startIndex)
        {

            //case i;
            var randomGen = new Random();
            int startPoint = startIndex;
            int rightPointer = 0;
            int leftPointer = 0;
            int distance = 0;

            //startPoint = 0; //randomGen.Next(0, blocks.Count);

            var resultList = new List<int>();


            if (startPoint == 0)
            {
                resultList.Add(startPoint);
                rightPointer = startPoint + 1;
                leftPointer = -1;
            }
            else if (startPoint > 0 & startPoint < blocks.Count - 1)
            {

                leftPointer = startPoint - 1;
                rightPointer = startPoint + 1;
            }
            else if (startPoint == blocks.Count - 1) {

                resultList.Add(startPoint);
                leftPointer = startPoint - 1;
                rightPointer = blocks.Count;
            }


            int currentPointA = startPoint;
            while (rightPointer < blocks.Count) {
                
                if (blocks[currentPointA] <= blocks[rightPointer]) {
                    resultList.Add(rightPointer);
                    currentPointA = rightPointer;
                    rightPointer++;
                }
                else
                {
                    break;
                }
            }

            int currentPointB = startPoint;
            while (leftPointer >= 0) {
                if (blocks[currentPointB] <= blocks[leftPointer])
                {
                    resultList.Add(leftPointer);
                    currentPointB = leftPointer;
                    leftPointer--;
                }
                else {
                    break;
                }
                        
            }

            if (resultList.Any()) {
                int J = resultList.Min();
                int K = resultList.Max();

                distance = K - J + 1;
            }
            // J == minimumIndex, K = maximiumIndex
            
            return distance;
        }

    }
}
