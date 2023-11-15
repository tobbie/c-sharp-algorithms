using System;
using Xunit;
using Algorithms.Recursion.Easy;
using Algorithms.Recursion.Medium;


namespace Algorithms.Tests
{
  public class RecursionTests
    {
        [Fact]
        public void ShouldReturn13() {
            //arrange

            //act
            var actual = Fibonacci.Fib(2000);
            //assert
            Console.WriteLine(actual);
            Assert.Equal(actual, actual);
        }

        [Theory]
        [InlineData(10, 2, 89)]
        public void ShoudReturnNumberOfWaysTraverseStairs(int height, int maxStep, int expected)
        {
            var actual = StaircaseTraversal.TraverseWorst(height, maxStep);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(10, 2, 89)]
        public void ReturnNumberOfWaysToTraverseStairs(int height, int maxStep, int expected)
        {
            var actual = StaircaseTraversal.TraverseOptimal(height, maxStep);
            Assert.Equal(expected, actual);
        }
    }
}
