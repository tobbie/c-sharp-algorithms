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

        public GraphTraversal()
        {
            Graph = new Dictionary<char, List<char>>();
            Graph.Add('a', new List<char> { 'c', 'b' });
            Graph.Add('b', new List<char> { 'd' });
            Graph.Add('d', new List<char> { 'f' });
            Graph.Add('c', new List<char> { 'e' });
            Graph.Add('e', new List<char> {  });
            Graph.Add('f', new List<char> { });

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
            
            


    }
}
