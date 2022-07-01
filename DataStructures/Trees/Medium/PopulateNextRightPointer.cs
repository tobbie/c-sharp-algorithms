using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataStructures.Trees.Medium
{
   public class PopulateNextRightPointer
    {
        public static BTNode<int> Connect(BTNode<int> root)
        {
            var queue = new Queue<(BTNode<int>, int)>();
            queue.Enqueue((root, 0));

            while(queue.Count > 0)
            {
                var (currentNode, level) = queue.Dequeue();


                var (nextNode, nodeLevel) = queue.Count > 0 ? queue.Peek() : (null, -1);
                if (nextNode == null || level != nodeLevel)
                    currentNode.Next = null;
                else if (level == nodeLevel)
                    currentNode.Next = nextNode;

                if (currentNode.Left is not null)
                    queue.Enqueue((currentNode.Left, level + 1));

                if (currentNode.Right is not null)
                    queue.Enqueue((currentNode.Right, level + 1));
            }

            return root;

        }
    }
}
