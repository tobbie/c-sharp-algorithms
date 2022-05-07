using System;
using Xunit;
using Algorithims.DynamicProgramming.Medium;

namespace Algorithms.Tests
{
    public class WaysToTraverseGraphTests
    {
        [Fact]
        public void ShouldReturn10() {
            //arrange

            int width = 10;
            int height = 10;

            //act

            var actual = NumberOfWaysToTraverseGraph.NumberOfWays(width, height);

            //assert
            Assert.Equal(48620, actual);
        }
    }
}
