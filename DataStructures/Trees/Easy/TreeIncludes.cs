using System;
using Common;

namespace DataStructures.Trees.Easy
{
    public class TreeIncludes
    {
        public static bool HasTarget(BTNode<char> root, char target)
        {
            if (root == null)
                return false;

            bool leftHasTarget =  HasTarget(root.Left, target);
            bool rightHasTarget = HasTarget(root.Right, target);

            return root.Value == target || leftHasTarget || rightHasTarget;
        }

    }
}
