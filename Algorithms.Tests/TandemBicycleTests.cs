using Xunit;
using Algorithms.Greedy.Easy;

namespace Algorithms.Tests
{
    public class TandemBicycleTests
    {
        [Fact]
        public void ShouldReturn32() 
        {
            //Arrange

            var redShirtSpeeds = new int[] { 5, 5, 3, 9, 2 };
            var blueShirtSpeeds = new int[] { 3, 6, 7, 2, 1 };
            bool fastest = true;

            //Act

            var actual = TandemBicycle.TandemTotal(redShirtSpeeds, blueShirtSpeeds, fastest);
            var expected = 32;

            //Assert
            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void ShouldReturn25()
        {
            //Arrange

            var redShirtSpeeds = new int[] { 5, 5, 3, 9, 2 };
            var blueShirtSpeeds = new int[] { 3, 6, 7, 2, 1 };
            bool fastest = false;

            //Act

            var actual = TandemBicycle.TandemTotal(redShirtSpeeds, blueShirtSpeeds, fastest);
            var expected = 25;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
