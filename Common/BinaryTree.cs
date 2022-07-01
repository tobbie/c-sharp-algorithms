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
}
