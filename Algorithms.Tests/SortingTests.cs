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

        [Theory]
        [InlineData(new int[] { 8, 5, 2, 9, 5, 6, 3 }, new int[] { 2, 3, 5, 5, 6, 8, 9 })]
        [InlineData(new int[] { 7, 5, 2, 9, 6, 4, 3 }, new int[] { 2, 3, 4, 5, 6, 7, 9 })]
        public void ShouldInsertionSort(int[] inputArray, int[] expected)
        {
            //act
            var actual = InsertionSort.Sort(inputArray);

            Assert.Equal(expected.ToList(), actual.ToList());
        }
    }
}
