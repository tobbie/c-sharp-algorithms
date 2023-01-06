
using Xunit;
using Patterns.TwoPointers;
using DataStructures.Strings.Easy;

namespace Algorithms.Tests
{
  public class TwoPointerTests
    {
        [Theory]
        [InlineData("RACEACAR", false)]
        [InlineData("RACECAR", true)]
        [InlineData("kayak", true)]
        [InlineData("hello", false)]
        public void ShouldDeterminIfStringIsPalindrome(string input, bool expected)
        {
            var actual = ValidPalindrome.IsPalindrome(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] {3, 7, 1, 2, 8, 4, 5 }, 20, true)]
        [InlineData(new int[] { 1,-1, 0 }, -1, false)]
        [InlineData(new int[] { 1, -1, 0 }, 1, false)]
        [InlineData(new int[] { 3, 7, 1, 2, 8, 4, 5 }, 10, true)]
        [InlineData(new int[] { 3, 7, 1, 2, 8, 4, 5 }, 21, false)]
        public void ShouldFindSumofThree(int[] array, int target, bool expected)
        {
            var actual = ThreeSum.FindSumOfThree(array, target);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello    world", "world hello")]
        //The quick brown fox jumped over the lazy dog.
        [InlineData("The quick brown fox jumped over the lazy dog.", "dog. lazy the over jumped fox brown quick The")]
        [InlineData("We love Python.", "Python. love We")]
        //We love Python.
        public void ShouldReversWords(string input, string expected)
        {
            var actual = ReverseWords.ReverseStringWords(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("DEEAD" , true)]
       
        [InlineData("DAEED", true)]
       // [InlineData("DAEED", true)]
        [InlineData("eeccccbebaeeabebccceea", true)]

        public void CanBeValidPalindrome(string input, bool expected)
        {
            var actual = ValidPalindrome2.IsValid(input);
            Assert.Equal(expected, actual);
        }
    }
}
