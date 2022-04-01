using Xunit;
using Algorithims.Greedy.Medium;

namespace Algorithms.Tests
{
   public class ValidStartingCityTests
    {
        [Fact]
        public void ShouldReturnValidStartingCity() { 
            //arrange
            var distances = new int[] { 5, 25, 15, 10, 15 };
            var fuel = new int[] { 1, 2, 1, 0, 3 };
            int mpg = 10;

            //act
            var actual = ValidStartingCity.GetValidStartingCity(distances, fuel, mpg);
            var expected = 4;



            //assert
            Assert.Equal(expected, actual);
        }
    }
}
