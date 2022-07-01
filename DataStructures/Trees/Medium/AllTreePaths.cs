using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataStructures.Trees.Medium
{
    public class AllTreePaths
    {
        public static List<List<char>> TreePath(BTNode<char> root)
        {
            var result = TreePathsHelper(root);
            
            foreach (var path in result)
               
                path.Reverse();
            

            return result;
            
        }
        private static List<List<char>> TreePathsHelper(BTNode<char> root)
        {
            if (root == null)
                return new List<List<char>>(); //[]
            if (root.Left == null && root.Right == null) // leaf node
                return new List<List<char>> { new List<char> { root.Value } };

            var leftSubPath = TreePathsHelper(root.Left);
            var rightSubPath = TreePathsHelper(root.Right);
           
            var paths = new List<List<char>>();

            foreach (var path in leftSubPath)
            {
                path.Add(root.Value);
                paths.Add(path);
            }

            foreach (var path in rightSubPath )
            {
                path.Add(root.Value);
                paths.Add(path);
            }

            return paths;                    
        }
    }
}
