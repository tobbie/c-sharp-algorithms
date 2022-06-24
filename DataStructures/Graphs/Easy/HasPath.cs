using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs.Easy
{
    public class HasPath
    {
        public static bool GraphHasPathBFS(Dictionary<char, List<char>> graph, char source, char destination)
        {
            //BFS

            var queue = new Queue<char>();
            queue.Enqueue(source);

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current == destination)
                    return true;

                foreach (var item in graph[current])         
                    queue.Enqueue(item);
                
            }

            return false;
        }

        public static bool GraphHasPathDFS(Dictionary<char, List<char>> graph, char source, char destination)
        {
            //DFS

            var stack = new Stack<char>();
            stack.Push(source);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                if (current == destination)
                    return true;

                foreach (var item in graph[current])
                    stack.Push(item);

            }

            return false;
        }
    }
}
