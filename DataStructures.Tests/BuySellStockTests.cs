using DataStructures.Arrays.Neetcode;
using Xunit;

namespace DataStructures.Tests
{
    public class BuySellStockTests
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        [InlineData(new int[] { 1, 2 }, 1)]
        [InlineData(new int[0], 0)]
        [InlineData(new int[] { 2 }, 0)]
        public void MaxProfit_ComputesExpectedResult(int[] prices, int expected)
        {
            var actual = BuySellStock.MaxProfit(prices);
            Assert.Equal(expected, actual);
        }
    }
}