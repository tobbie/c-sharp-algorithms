using System;
using System.Collections.Generic;
using static System.Console;

namespace DataStructures.Graphs
{
    public class GraphTraversal
    {
        /**
         *   a --> c
         *   |     |
         *   b     e
         *   |
         *   d---->f
         *   
         **/

        
        public Dictionary<char, List<char>> Graph { get; private set; }
        public int[][] Grid { get; private set; }

        public GraphTraversal()
        {
            Graph = new Dictionary<char, List<char>>();
            Graph.Add('a', new List<char> { 'b', 'c' });
            Graph.Add('b', new List<char> { 'd' });
            Graph.Add('d', new List<char> { 'f' });
            Graph.Add('c', new List<char> { 'e' });
            Graph.Add('e', new List<char> {  });
            Graph.Add('f', new List<char> { });

            Grid =  new int[4][];
            Grid[0] = new int[] { 1, 2, 3, 4 };
            Grid[1] = new int[] { 5, 6, 7, 8 };
            Grid[2] = new int[] { 9, 10, 11, 12 };
            Grid[3] = new int[] { 13, 14, 15, 16 };

        }
        public void DepthFirstSearchPrint(Dictionary<char, List<char>> graph, char root)
        {

            /**
             * DFS uses a stack 
             * 1. initialize the stack with the root node
             * 2. while stack.count > 0
             * 3. perform operation
             * 4. add neigbhours of currentRoot to stack
                * 5. repeat
            **/

            var stack = new Stack<char>();
            stack.Push(root);

            while(stack.Count > 0)
            {
                var current = stack.Pop();
                Write($"{current} ");

                foreach (var item in graph[current])               
                    stack.Push(item);             
            }
            WriteLine();
        }

        public void DepthFirstRecursive(Dictionary<char,List<char>> graph, char source)
        {
            Write($"{source}");
            foreach (var neigbhor in graph[source])
            {
                DepthFirstRecursive(graph, neigbhor);
            }
        
        }
        public void BreadthFirstSearchPrint(Dictionary<char, List<char>> graph, char root)
        {
            /**
             * BFS uses a queue.
             * initialize queue with root node, starting point.
             * while queue.count > 0, 
             * perform operation
             * do another interation over neigbhours of currentItem
             * add each neighbour to queue
             * repeat
             **/

            var queue = new Queue<char>();
            queue.Enqueue(root);

          
            
            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
                Write($"{current} ");
                foreach (var item in graph[current])            
                    queue.Enqueue(item);               
            }

            ReadLine();
        }

        public int[] DepthFirstSearchGrid(int[][] grid)
        {
            List<int> result = new List<int>();
            var visited = new HashSet<string>();

            DfsGridHelper(0, 0, visited, grid, result);

            foreach (var item in result)
            {
                Write($"{item},");
            }
            WriteLine();
            return result.ToArray();
        }

        private void DfsGridHelper(int row, int col, HashSet<string> visited, int[][]grid, List<int> result)
        {
            if (row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length)
                return;

            if (visited.Contains($"{row},{col}"))
                return;

            visited.Add($"{row},{col}");

            result.Add(grid[row][col]);

            DfsGridHelper(row - 1, col, visited, grid, result);
            DfsGridHelper(row + 1, col, visited, grid, result);
            DfsGridHelper(row, col -1, visited, grid, result);
            DfsGridHelper(row, col +1, visited, grid, result);

        }
            
            


    }
}
