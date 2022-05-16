using System;
using Algorithims.Sort.Easy;
using Xunit;
using System.Linq;

namespace Algorithms.Tests
{
   public class SortingTests
    {
        [Theory]
        [InlineData(new int[] {8, 5, 2, 9, 5, 6, 3}, new int[] {2, 3, 5, 5, 6, 8, 9})]
        public void ShouldBubbleSort(int [] inputArray,int[] expected)
        {
            //act
            var actual = BubbleSort.Sort(inputArray);

            Assert.Equal(expected.ToList(), actual.ToList());
        }
    }
}
