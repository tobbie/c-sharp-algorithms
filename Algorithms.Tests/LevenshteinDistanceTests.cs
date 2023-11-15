using Xunit;
using System;
using Algorithms.DynamicProgramming.Medium;

namespace Algorithms.Tests
{
    public class LevenshteinDistanceTests
    {
        [Fact]
        public void ShouldReturn2() {
            //arrange
            string string1 = "horse";
            string string2 = "ros";
            //act

            var actual = LevenshteinDistance.MinimumEdits(string1, string2);

            //assert
            Assert.Equal(3, actual);
        }
    }
}
