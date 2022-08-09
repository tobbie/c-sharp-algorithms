using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataStructures.Microsoft
{
   public class MinimumDeletionsToMakeFrequenciesUnique
    {
        public static int MinimumDeletions(string s)
        {
            var priorityQueue = new PriorityQueue<int, int>(new IntMaxComparer());
            var frequencies = new Dictionary<char, int>();
            int deleteCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!frequencies.ContainsKey(s[i]))
                    frequencies.Add(s[i], 1);
                else
                    frequencies[s[i]] += 1;
            }

            // insert frequencies into queue;
            foreach (var key in frequencies)
                priorityQueue.Enqueue(key.Value, key.Value);

            while(priorityQueue.Count > 1)
            {
                int topElement = priorityQueue.Dequeue();
                if(topElement == priorityQueue.Peek())
                {
                    topElement -= 1;
                    deleteCount++;

                    if (topElement > 0)
                        priorityQueue.Enqueue(topElement, topElement);
                }
            }

            return deleteCount;
            
        }
    }
}
