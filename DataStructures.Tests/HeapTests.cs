
using Xunit;
using System.Linq;
using DataStructures.Heaps.Medium;

namespace DataStructures.Tests
{
    public class HeapTests
    {
        [Theory]
        [InlineData(1, 1, 7, "ccaccbcc")]
        public void ShouldReturnLongestHappyString(int a, int b, int c, string expected)
        {
            var actual = LongestHappyString.LongestDiverseString(a, b, c);

            Assert.Equal(expected, actual);
        }
    }
}
