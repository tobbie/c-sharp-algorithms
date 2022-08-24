using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftInterview
{
    public class SerilizeAndDeserilizeBinaryTree
    {
        // Encodes a tree to a single string.

        private int _index { get; set; }
        public string serialize(TreeNode root)
        {
            var array = new List<string>();

            void serializeHelper(TreeNode node)
            {
                if (node == null)
                {
                    array.Add("N");
                    return;
                }

                array.Add(node.val.ToString());
                serializeHelper(node.left);
                serializeHelper(node.right);
            }

            serializeHelper(root);
            return string.Join(',', array);
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            var array = data.Split(',');
            _index = 0;
            return DeserilizeHelper(array, _index);
        }


        private TreeNode DeserilizeHelper(string[] dataArray, int index)
        {
            if (dataArray[_index] == "N")
            {
                _index += 1;
                return null;
            }

            var node = new TreeNode(int.Parse(dataArray[_index]));
            _index += 1;
            node.left = DeserilizeHelper(dataArray, _index);
            node.right = DeserilizeHelper(dataArray, _index);
            return node;
        }
    }

   
 // Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
 
}
