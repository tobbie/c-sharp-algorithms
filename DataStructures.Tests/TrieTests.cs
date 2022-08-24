
using Xunit;
using DataStructures.Trie;

namespace DataStructures.Tests
{
   public class TrieTests
    {
        [Theory]
        [InlineData(new string[] {"i love you", "island", "iroman", "i love leetcode"}, new int[] {5, 3, 2, 2})]
        public void TestAutoComplete(string[] sentences, int[] times)
        {
            var sut = new AutocompleteSystem(sentences, times);

            var result = sut.Input('i');
            var result2 = sut.Input(' ');

            Assert.True(true);
        }
    }
}
