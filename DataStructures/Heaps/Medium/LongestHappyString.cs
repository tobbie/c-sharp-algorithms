using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;


namespace DataStructures.Heaps.Medium
{
 public class LongestHappyString
    {
        public static string LongestDiverseString(int a , int b, int c)
        {
            var result = new StringBuilder();
            var maxHeap = new PriorityQueue<char, int>(new IntMaxComparer());
            maxHeap.Enqueue('a', a);
            maxHeap.Enqueue('b', b);
            maxHeap.Enqueue('c', c);

            while(maxHeap.Count > 0)
            {
               maxHeap.TryDequeue(out char currentChar, out int count);
               if(result.Length > 1 && IsMaxSequence(result, currentChar))
                {
                    if (maxHeap.Count == 0)
                        break;
                    maxHeap.TryDequeue(out char nextChar, out int nextCharCount);
                    result.Append(nextChar);
                    nextCharCount -= 1;

                    if (nextCharCount > 0)
                        maxHeap.Enqueue(nextChar, nextCharCount);
                }
               else
                {
                    result.Append(currentChar);
                    count -= 1;
                }

                if (count > 0)
                    maxHeap.Enqueue(currentChar, count);
            }

            return result.ToString();
        }

        private static bool IsMaxSequence(StringBuilder value, char currentChar)
        {
            return (value[^1] == value[^2]  && value[^1] == currentChar);
        }
    }
}
