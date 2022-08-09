using System;
using Xunit;
using Algorithims.BitwiseOperation;
using System.Linq;

namespace Algorithms.Tests
{
    public class BitwiseOperationsTests
    {
        [Theory]
        [InlineData(new int[] {1, 5, 2, 6, 4}, 3)]
        public void ShouldFindMissingNumber(int[] input, int expected)
        {
           var actual = FindMissingNumber.MissingNumber(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 4, 2, 1, 3, 2, 3 }, 4)]
        public void ShouldFindSingleNumber(int[] input, int expected)
        {
            var actual = FindSingleNumber.Find(input);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new int[] { 2, 1, 3, 2 }, new int[] {3, 1})]
        public void ShouldFindSingleNumbers(int[] input, int[] expected)
        {
            var actual = FindSingleNumbers.Find(input);
            Assert.Equal(expected.ToList(), actual.ToList());
        }


        [Theory]
        //[InlineData(8, 7)]
        [InlineData(10, 5)]
        public void ShouldFindBitwiseComplement(int input, int expected)
        {
            var actual = BitwiseComplement.GetComplement(input);
            Assert.Equal(expected, actual);
        }
    }
}
