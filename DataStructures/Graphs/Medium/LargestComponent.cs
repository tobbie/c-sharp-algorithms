using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs.Medium
{
   public class LargestComponent
    {
       
        public  int GetLargestComponent(Dictionary<int, List<int>> graph)
        {
            int largest = 0;
            var visitedNodes = new HashSet<int>();

            foreach (var key in graph.Keys)
            {
                if (visitedNodes.Contains(key))
                    continue;

               int componentCount =  BreadthFristSearchHelper(key, graph, visitedNodes);
               largest = Math.Max(largest, componentCount);          
            }

            return largest;
        }

        private int BreadthFristSearchHelper(int key, Dictionary<int, List<int>> graph, HashSet<int> hashSet)
        {
            var queue = new Queue<int>();
            queue.Enqueue(key);
            hashSet.Add(key);

            int count = 0;

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
                count += 1;

                foreach (var neigbhour in graph[current])
                {
                    if (hashSet.Contains(neigbhour))
                        continue;

                    queue.Enqueue(neigbhour);
                    hashSet.Add(neigbhour);
                }
            }

            return count;
        }
    }
}
