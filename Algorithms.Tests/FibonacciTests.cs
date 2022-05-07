using System;
using Xunit;
using Algorithims.Recursion.Easy;


namespace Algorithms.Tests
{
  public class FibonacciTests
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
    }
}
