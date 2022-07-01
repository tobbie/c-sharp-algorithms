using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataStructures.Trees.Medium
{
    public class PathFinder
    {
        public static List<char> Find(BTNode<char> root, char target)
        {
            var result = PathFinderHelper(root, target);
            if (result is null)
                return null;

            result.Reverse();
            return result;
        }

        private static List<char> PathFinderHelper(BTNode<char> root, char target)
        {
            if (root == null)
                return null;

            if (root.Value == target)
                return new List<char> { root.Value }; //{'target'}

            var leftPath = PathFinderHelper(root.Left, target);
            var rightPath = PathFinderHelper(root.Right, target);

            if(leftPath != null)
            {
                leftPath.Add(root.Value);
                return leftPath;
            }

            if(rightPath != null)
            {
                rightPath.Add(root.Value);
                return rightPath;
            }

            return null;

        }
    }
}
