
using Xunit;
using Algorithims.SlidingWindow;
using Patterns.SlidingWindow;
using System.Linq;

namespace Algorithms.Tests
{
    public class SlidingWindowTests
    {
        [Theory]
        [InlineData(new int[] {2, 1, 5, 2, 3, 2}, 7, 2)]
        [InlineData(new int[] { 2, 1, 5, 2, 8 }, 7, 1)]
        [InlineData(new int[] { 3, 4, 1, 1, 6 }, 8, 3)]
        public void ShouldReturnLengthOfSmallesSubArray(int[] array, int S, int expected)
        {
            int actual = SmallestSubArrayWithGreaterSum.FinMinSubArray(S, array);
            Assert.Equal(expected, actual);
        }

        [Theory]
       // [InlineData(new int[] { 1, 2, 3, 4 , 5, 6, 7,8,9 ,10}, 3, new int[] {3, 4, 5, 6, 7, 8, 9, 10})]
       // [InlineData(new int[] { 4, 5, 6, 1, 2, 3 }, 4, new int[] { 6, 6, 6 })]
       // [InlineData(new int[] { -1, -1, -2, -4, -6, -7 }, 3, new[] {-1,-1, -2, -4 })]
        [InlineData(new int[] { 7, 2, 4}, 2, new[] { 7, 4 })]

        public void ShouldReturnMaximumOfSlidingWindow(int[] array, int window, int[] expected)
        {
            var actual = MaximumInSlidingWindow.FindMaximum(array.ToList(), window);
            Assert.Equal(expected, actual.ToArray());
        }

        [Theory]
        [InlineData("AGCTGAAAGCTTAGCTG", 5, new string[] {"AGCTG"})]
        [InlineData("CCATATGTATGGATAT", 4, new string[] { "ATAT", "TATG" })]
        public void ShouldFindSubSequences( string input, int window, string[] expected)
        {
            var actual = RepeatedDnaSequences.FindRepeatedSequences(input, window);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("azjskfztf", "sz", "skfz")]
        [InlineData("abcdebdde", "bde","bcde")]
        [InlineData("qwewerrty", "werty", "werrty")]
        [InlineData("alpha", "la", "lpha")]
        [InlineData("beta", "ab", "")]
        [InlineData("fgrqsqsnodwmxzkzxwqegkndaa", "kzed", "kzxwqegknd")]
        public void ShouldFindMinimunString(string input, string subString, string expected)
        {
            var actual = MinimumWindowSubsequence.MinimumWindow(input, subString);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("PATTERN","TN","TERN")]
        [InlineData("LIFE", "I", "I")]
        [InlineData("ABRACADABRA", "ABC", "BRAC")]
        [InlineData("STRIKER", "RK", "RIK")]
        public void ShouldFindMinimunWindowSubstring(string input, string subString, string expected)
        {
            var actual = MinimumWindowSubstring.FindMinimumSubstring(input, subString);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("pwwkew", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("AAAABBBBCCCCDDDD", 2)]
        [InlineData("ABCDEDCBA", 5)]
        [InlineData("ABCDEFGHI", 9)]
        [InlineData("", 0)]
        public void ShouldFindLongestSubstring(string input, int expected)
        {
            var actual = LongestSubstringWithoutRepeatingCharacters.LongestSubstring(input);

            Assert.Equal(expected, actual.Item1);
        }

        [Theory]
        [InlineData(new int[] {2, 3, 1, 2, 4, 3}, 7, 2)]
        [InlineData(new int[] { 1, 4, 4 }, 4, 1)]
        [InlineData(new int[] { 1,2, 3, 4 }, 10,4)]
        [InlineData(new int[] {1, 1, 1,1,1 ,1, 1, 1,1 , 1}, 11, 0)]
        public void ShouldFindMinimum(int[] array, int target, int expected)
        {
            var actual = MinimumSizeSubArraySum.FindMinimumSize(array, target);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[] { 10, 4, 11, 1, 5 }, 7)]
        [InlineData(new int[] { 10, 8, 6, 4, 2 }, 0)]
        public void ShouldFindMaxProfit(int[] array,  int expected)
        {
            var actual = BestTimeToBuyStock.MaxProfit(array);

            Assert.Equal(expected, actual);
        }
    }
}
