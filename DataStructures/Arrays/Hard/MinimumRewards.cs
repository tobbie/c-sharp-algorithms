using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace DataStructures.Arrays.Hard
{
    public class MinimumRewards
    {
        private const int _initialScore = 1;
        public static void Run()
        {

            var scores = new int[] { 8, 4, 2, 1, 3, 6, 7, 9, 5 };
            WriteLine($"Minimum Reward is: {OptimalSolution2(scores)} ");
        }

        public static int OptimalSolution1(int[] scores) //O(n) time //O(n) space
        {
            //create hashtable with all scores mapped to initial rewards of 1
            var rewardsDict = new Dictionary<int, int>();
            foreach (var score in scores)
            {
                rewardsDict.Add(score, _initialScore);
            }

            int leftPointer = 0, rightPointer = scores.Length - 1;

            while (leftPointer < (scores.Length -1) & rightPointer > 0) {

                if (scores[leftPointer] > scores[leftPointer + 1])
                {
                    if (!(rewardsDict[scores[leftPointer]] > rewardsDict[scores[leftPointer + 1]]))
                        rewardsDict[scores[leftPointer]] = rewardsDict[scores[leftPointer + 1]] + 1;
                }
                else {

                    if (!(rewardsDict[scores[leftPointer]] < rewardsDict[scores[leftPointer + 1]]))
                        rewardsDict[scores[leftPointer + 1]] = rewardsDict[scores[leftPointer]] + 1;
                }

               

                if (scores[rightPointer] > scores[rightPointer - 1])
                {
                    if (!(rewardsDict[scores[rightPointer]] > rewardsDict[scores[rightPointer - 1]]))
                        rewardsDict[scores[rightPointer]] = rewardsDict[scores[rightPointer - 1]] + 1;

                }
                else
                {
                    if (!(rewardsDict[scores[rightPointer]] < rewardsDict[scores[rightPointer - 1]]))
                        rewardsDict[scores[rightPointer - 1 ]] = rewardsDict[scores[rightPointer]] + 1;
                }

                leftPointer++;
                rightPointer--;

            }

            //var rewardsList = rewardsDict.Values.ToArray();
            return rewardsDict.Values.Sum();
        }

        public static int OptimalSolution2(int[] scores) {
            //create hashtable with all scores mapped to initial rewards of 1
            var rewardsDict = new Dictionary<int, int>();
            foreach (var score in scores)
            {
                rewardsDict.Add(score, _initialScore);
            }

            int leftPointer = 1, rightPointer = scores.Length - 2;

            while (leftPointer < scores.Length & rightPointer >= 0) {
                if (scores[leftPointer] > scores[leftPointer - 1])

                    rewardsDict[scores[leftPointer]]
                         = Max(rewardsDict[scores[leftPointer - 1]] + 1, rewardsDict[scores[leftPointer]]);

                leftPointer++;

                if (scores[rightPointer] > scores[rightPointer + 1])
                    rewardsDict[scores[rightPointer]]
                        = Max(rewardsDict[scores[rightPointer + 1]] + 1, rewardsDict[scores[rightPointer]]);

                rightPointer--;
            }

            /**
            while (rightPointer >= 0) {
                if (scores[rightPointer] > scores[rightPointer + 1])
                    rewardsDict[scores[rightPointer]]
                        = Max(rewardsDict[scores[rightPointer + 1]] + 1, rewardsDict[scores[rightPointer]]);

                rightPointer--;
            }
            **/
            var rewardsList = rewardsDict.Values.ToArray();
            return rewardsDict.Values.Sum();
        }

    }
}
