using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Algorithms.Recursion.Medium
{
   public class StaircaseTraversal
    {
        public static int TraverseWorst(int height, int maxStep)
        {
            return TraverseHelper(height, maxStep);
        }

        private static int TraverseHelper(int height, int maxStep)
        {
            if (height <= 1)
                return 1;

            int numberOfWays = 0;
            for (int i = Min(height, maxStep); i > 0; i--)
            {
                numberOfWays += TraverseHelper(height - i, maxStep);
            }
            return numberOfWays;
        }

        public static int TraverseOptimal (int height, int maxStep)
        {
            var memoize = new Dictionary<int, int>();
            memoize.Add(0, 1);
            memoize.Add(1, 1);
            return TraverseHelper(height, maxStep, memoize);
        }

        private static int TraverseHelper(int height, int maxStep, Dictionary<int, int> memoize)
        {
            if (memoize.ContainsKey(height))
                return memoize[height];

            int numberOfWays = 0;
            for (int i = Min(height, maxStep); i > 0; i--)
            {
                numberOfWays += TraverseHelper(height - i, maxStep, memoize);
            }
            memoize[height] = numberOfWays;
            return numberOfWays;
        }
    }
}
