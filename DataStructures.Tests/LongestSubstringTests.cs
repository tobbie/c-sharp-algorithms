using DataStructures.Arrays.Neetcode;
using Xunit;

namespace DataStructures.Tests
{
    public class LongestSubstringTests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        [InlineData("dvdf", 3)]
        public void LengthOfLongestSubstring_ReturnsExpected(string s, int expected)
        {
            var actual = LongestSubstringWithoutDuplicateCharacter.LengthOfLongestSubstring(s);
            Assert.Equal(expected, actual);
        }
    }
}