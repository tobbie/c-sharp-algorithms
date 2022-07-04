using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
  public class BinaryTree
    {
    }

    public class BTNode<T>
    {
        public T Value { get; private set; }
        public BTNode<T> Left { get; set; }
        public BTNode<T> Right { get; set; }
        public BTNode<T> Next { get; set; }

        public BTNode(T value)
        {
            Value = value;
        }
    }


    public class GraphNode
    {
        public int val;
        public IList<GraphNode> neighbors;

        public GraphNode()
        {
            val = 0;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int _val)
        {
            val = _val;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int _val, List<GraphNode> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
