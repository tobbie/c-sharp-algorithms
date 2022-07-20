using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataStructures.Microsoft
{
    public class CourseSchedule2
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            var graph = Util.BuildGraph(numCourses, prerequisites);
            var visited = new HashSet<int>();
            var visiting = new HashSet<int>();

            var courseOrder = new List<int>();

            foreach (var course in graph.Keys)
            {
                if (HasCycle(course, visiting, visited, graph, courseOrder))
                    return new int[] { };
            }

            return courseOrder.ToArray();
        }

        private bool HasCycle(int course, HashSet<int> visiting, HashSet<int> visited, Dictionary<int, List<int>> graph, List<int> courseOrder)
        {
            if (visited.Contains(course))
                return false;

            if (visiting.Contains(course))
                return true;

            visiting.Add(course);

            foreach (var preReq in graph[course])
            {
                if (HasCycle(preReq, visiting, visited, graph, courseOrder) == true)
                    return true;
            }

            visiting.Remove(course);
            visited.Add(course);
            courseOrder.Add(course);

            return false;
        }
    }
}
