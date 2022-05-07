using Xunit;
using Algorithims.DynamicProgramming.Medium;
using System.Linq;
using System.Collections.Generic;

namespace Algorithms.Tests
{
   public class MaximumIncreasingSubsequenceTests
    {
        [Fact]
        public void ShouldReturn35()
        {
            //arrange
            int [] inputArray = new int[] { 8, 12, 2, 3, 15, 5, 7 };
            var expectedSequence = new List<int>{ 8, 12, 15 };


            //act
            var actual = MaximumSumIncreasingSubsequence.MaximumSum(inputArray);
            var actualSequence = actual[1];

            //assert
            Assert.Equal(35, actual.First()[0]);
            Assert.Equal(expectedSequence, actualSequence);
        }
    }
}
