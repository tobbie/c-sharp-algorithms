using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataStructures.Graphs.Medium
{
   public class CourseSchedule
    {
        public static bool CanFinish (int numCourses, int[][] prerequisites)
        {
            var graph = Util.BuildGraph(numCourses, prerequisites);
            var visiting = new HashSet<int>();
            var visited = new HashSet<int>();


            foreach (var node in graph.Keys)
            {
                if (HasCycle(node, visiting, visited, graph))
                   return false;
            }

            return true;
        }

        private static bool HasCycle(int node, HashSet<int> visiting, HashSet<int> visited, Dictionary<int, List<int>> graph)
        {
            if (visited.Contains(node))
                return false;
            if (visiting.Contains(node))
                return true;

            visiting.Add(node);
            foreach (var neigbhor in graph[node])
            {
                if (HasCycle(neigbhor, visiting, visited, graph) == true)
                    return true;
            }

            visiting.Remove(node);
            visited.Add(node);

            return false;

        }

        
    }
}
