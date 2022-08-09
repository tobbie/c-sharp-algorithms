using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Microsoft
{
    public class MaximalNetworkRank
    {
        public static int MaxRank(int n, int[][] roads)
        {
            var graph = BuildGraph(n, roads);

            var maxRank = 0;


            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (!graph[i].Contains(j))
                        maxRank = Math.Max(maxRank, graph[i].Count + graph[j].Count);
                    else
                        maxRank = Math.Max(maxRank, (graph[i].Count + graph[j].Count) -1 );
                }
            }

            return maxRank;
        }


        private static Dictionary<int, HashSet<int>> BuildGraph(int n, int[][] roads)
        {
            var graph = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < n; i++)         
                graph.Add(i, new HashSet<int>());

            foreach(var road in roads)
            {
                graph[road[0]].Add(road[1]);
                graph[road[1]].Add(road[0]);
            }

            return graph;
        }
    }
}
