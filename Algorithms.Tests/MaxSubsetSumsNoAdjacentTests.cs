using Xunit;
using Algorithms.DynamicProgramming.Medium;
using DataStructures.Arrays.Neetcode;

namespace Algorithms.Tests
{
   public class MaxSubsetSumsNoAdjacentTests
    {
        [Fact]
        public void ShouldReturn33() { 
         //Arrrange
         var array = new int[] { 7, 10, 12, 7, 9, 14 };

            //Act 

         var actual =   MaxSumsNoAdjacent.MaxSubsetSumNoAdjacent(array, false);
         var expected = 33;
       
         //Assert
         Assert.Equal(expected, actual);
        
        }

        [Fact]
        public void ShouldNotReturn33()
        {
            //Arrrange
            var array = new int[] { 7, 10, 12, 7, 20, 14 };

            //Act 

            var actual = MaxSumsNoAdjacent.MaxSubsetSumNoAdjacent(array);
            var expected = 33;

            //Assert
            Assert.NotEqual(expected, actual);

        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1}, 4)]
        public void ShouldReturnMaxiumValue(int[] array, int expected)
        {
            var actual = HouseRobber.RobHouses(array);
            Assert.Equal(expected, actual);

           
        }


    }
}
