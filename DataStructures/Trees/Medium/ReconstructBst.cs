using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DataStructures.Trees.Medium
{
 
    public class ReconstructBst
    {
        //O(nlog n) time, O(n) space
        public BST Reconstruct(List<int> preOrderTraversalValues)
        {
            var root = new BST(preOrderTraversalValues[0]);

            for (int i = 1; i < preOrderTraversalValues.Count; i++)
            {
                var currentNode = root;
                var newNode = new BST(preOrderTraversalValues[i]);

                while (true)
                {
                    if (currentNode.Value > newNode.Value)
                    {
                        //go left
                        if (currentNode.Left == null)
                        {
                            currentNode.Left = newNode;
                            break;
                        }                         
                        else
                            currentNode = currentNode.Left;
                    }
                    else
                    {
                        //go right
                        if (currentNode.Right == null)
                        {
                            currentNode.Right = newNode;
                            break;
                        }                          
                        else
                           currentNode = currentNode.Right;
                    }                  
                }              
            }

            return root;
        }

        //Optimal - O(n) time, O(n) space
        public BST ReconstructTree(List<int> preOrderTraversalValues)
        {
            var treeInfo = new TreeInfo(0);
            var tree = ReconstructTreeHelper(int.MinValue,int.MaxValue, preOrderTraversalValues, treeInfo);
            return tree;
        }

        private BST ReconstructTreeHelper(int lowerBound, int upperBound, List<int> preOrderTraversalValues, TreeInfo currentSubtreeInfo)
        {
            if (currentSubtreeInfo.RootIndex == preOrderTraversalValues.Count)
                return null;

            var rootValue = preOrderTraversalValues[currentSubtreeInfo.RootIndex];
            
            if (rootValue < lowerBound || rootValue >= upperBound)
                return null;

            currentSubtreeInfo.RootIndex += 1;

            var leftSubtree = ReconstructTreeHelper(lowerBound, rootValue, preOrderTraversalValues, currentSubtreeInfo);
            var rightSubtree = ReconstructTreeHelper(rootValue, upperBound, preOrderTraversalValues, currentSubtreeInfo);
            return new BST(rootValue, leftSubtree, rightSubtree);

        }
    }

    public class BST
    {
        public int Value { get; private set; }
        public BST Left { get; set; }
        public BST Right { get; set; }

        public BST(int value, BST left = null, BST right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }      
    }

    public class TreeInfo
    {
        public int RootIndex { get; set; }
        public TreeInfo(int rootIndex)
        {
            RootIndex = rootIndex;
        }
    }
}
