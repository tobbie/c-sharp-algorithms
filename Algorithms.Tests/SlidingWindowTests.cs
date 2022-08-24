
using Xunit;
using Algorithims.SlidingWindow;

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
    }
}
