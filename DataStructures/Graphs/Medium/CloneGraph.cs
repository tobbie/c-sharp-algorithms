using System;
using System.Collections.Generic;
using Common;

namespace DataStructures.Graphs.Medium
{
    public class CloneGraph
    {
        public static GraphNode Clone(GraphNode node)
        {
            if (node is null)
                return null;

            var clonedDict = new Dictionary<GraphNode, GraphNode>();
            var queue = new Queue<GraphNode>();

            queue.Enqueue(node);
            clonedDict.Add(node, new GraphNode(node.val));

            while(queue.Count > 0)
            {
                var currentNode = queue.Dequeue();

                foreach (var neigbhour in currentNode.neighbors)
                {
                    if(!clonedDict.ContainsKey(neigbhour))
                    {
                        clonedDict.Add(neigbhour, new GraphNode(neigbhour.val));
                        queue.Enqueue(neigbhour);
                    }

                    clonedDict[currentNode].neighbors.Add(clonedDict[neigbhour]);

                }
            }
        
            return clonedDict[node];
        }
    }
}
