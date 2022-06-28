using System;
using System.Numerics;
using Common;

namespace DataStructures.Trees.Easy
{
    public class TreeMinimumValue
    {
        public static BigInteger GetMinimum(BTNode<long> root)
        {
            if (root == null)
                return (BigInteger)double.PositiveInfinity;

            var leftMin = GetMinimum(root.Left);
            var rightMin = GetMinimum(root.Right);

            return Math.Min(root.Value, (Math.Min((int)leftMin, (int)rightMin)));

        }
    }
}
