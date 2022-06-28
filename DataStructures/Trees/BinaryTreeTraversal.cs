using System;
using System.Collections.Generic;
using Common;
using System.Linq;

namespace DataStructures.Trees
{
    public class BinaryTreeTraversal
    {
        public static IList<IList<int>> LevelOrderTraversal(BTNode<int> root)
        {
            if (root is null)
                return null;

            var queue = new Queue<(BTNode<int>, int)>();
            var result = new List<IList<int>>();

         
            queue.Enqueue((root, 0));

            while(queue.Count > 0)
            {
                var (current, level) = queue.Dequeue();
                if (result.Count == level)
                    result.Add(new List<int>());

                result[level].Add(current.Value);
               
                if(current.Left is not null)
                    queue.Enqueue((current.Left, level + 1));
               
                if(current.Right is not null)
                    queue.Enqueue((current.Right, level + 1));              
            }

            return result;
            
        }


        public static IList<IList<int>> ZigZagLevelOrderTraversal(BTNode<int> root)
        {
            if (root is null)
                return null;
           
            var evenStack = new Stack<(BTNode<int>, int)>(); // R --> L
            var oddStack = new Stack<(BTNode<int>, int)>();  // L - R
          
            var result = new List<IList<int>>();


            evenStack.Push((root, 0));

            while (evenStack.Count > 0 ||  oddStack.Count > 0)
            {
                while(evenStack.Count > 0)
                {
                    var (currentNode, level) = evenStack.Pop();
                    BuildList(result,level, currentNode);

                    if(currentNode.Left is not null)
                        oddStack.Push((currentNode.Left, level + 1));

                    if(currentNode.Right is not null)
                        oddStack.Push((currentNode.Right, level + 1));

                }

                while(oddStack.Count > 0)
                {
                    var (currentNode, level) = oddStack.Pop();
                    BuildList(result, level, currentNode);

                    if (currentNode.Right is not null)
                        evenStack.Push((currentNode.Right, level + 1));

                    if (currentNode.Left is not null)
                        evenStack.Push((currentNode.Left, level + 1));
                }                             
            }
            return result;
        }

        private static void BuildList(IList<IList<int>> result, int level, BTNode<int> node)
        {
            if (result.Count == level)
                result.Add(new List<int>());

            result[level].Add(node.Value);
        }

        


        public static List<char> DepthFirstSearch(BTNode<char> root)
        {
            var result = new List<char>();
            var stack = new Stack<BTNode<char>>();
            stack.Push(root);

            while(stack.Count > 0)
            {
                var current = stack.Pop();
                result.Add(current.Value);
                
                //right before left so the DFS order is maintained.
                if (current.Right is not null)
                    stack.Push(current.Right);

                if (current.Left is not null)
                    stack.Push(current.Left);
            }

            return result;
        }

        public static List<char> BreadthFirstSearch(BTNode<char> root)
        {
            var result = new List<char>();
            var queue = new Queue<BTNode<char>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                result.Add(current.Value);

                if (current.Left is not null)
                    queue.Enqueue(current.Left);

                if (current.Right is not null)
                    queue.Enqueue(current.Right);

              
            }
            return result;
          
        }

        public static List<char> DepthFirstSearchRecursive(BTNode<char> root)
        {
            if (root == null)
                return new List<char>();

            var leftValues = DepthFirstSearchRecursive(root.Left);
            var rightValues = DepthFirstSearchRecursive(root.Right);

            return new List<char> { root.Value }.Concat(leftValues).Concat(rightValues).ToList();
        }


    }
}
