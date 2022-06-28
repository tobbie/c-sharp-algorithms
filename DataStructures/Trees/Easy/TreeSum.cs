using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataStructures.Trees.Easy
{
    public class TreeSum
    {
        public static int Sum(BTNode<int> root)
        {
            if (root == null)
                return 0;
            int leftSum =  Sum(root.Left);
            int rightSum = Sum(root.Right);

            return root.Value + leftSum + rightSum;
        }

        
    }

    /**
    public class BTNode<T> 
    {
        public T Value { get; private set; }
        public BTNode<T> Left { get; set; }
        public BTNode<T> Right { get; set; }

        public BTNode(T value)
        {
            Value = value;
        }
    }
    **/
}
