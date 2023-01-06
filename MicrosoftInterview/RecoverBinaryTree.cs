using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftInterview
{
    public class RecoverBinarySearchTree
    {
        private TreeNode First { get; set; }
        private TreeNode Second { get; set; }
        private TreeNode Previous = new TreeNode(int.MinValue);
        public void RecoverTree(TreeNode root)
        {
            InOrderTraverse(root);
            var temp = First.val;
            First.val = Second.val;
            Second.val = temp;
        }

        private void InOrderTraverse(TreeNode node)
        {
            if (node == null)
                return;

            InOrderTraverse(node.left);

            if(First == null && Previous.val > node.val)
            {
                First = Previous;
            }

            if(First != null && Previous.val > node.val)
            {
                Second = node;
            }

            Previous = node;
            InOrderTraverse(node.right);
        }
    }
}
