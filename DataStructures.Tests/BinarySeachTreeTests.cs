
using System.Collections.Generic;
using System.Linq;
using Xunit;
using DataStructures.Trees.Medium;
using DataStructures.Trees.Hard;

namespace DataStructures.Tests
{
  public class BinarySeachTreeTests
    {
        [Theory]
        [InlineData(new int[] {10, 4, 2, 1, 5, 17, 19, 18}, 10)]
        public void ShouldReconstructBst(int[] input, int expected)
        {
            var sut = new ReconstructBst();

            var actual = sut.Reconstruct(input.ToList());

            Assert.Equal(expected, actual.Value);
        }


        [Theory]
        [InlineData(new int[] { 10, 4, 2, 1, 5, 17, 19, 18 }, 10)]
        public void ShouldReconstructBstOptimally(int[] input, int expected)
        {
            var sut = new ReconstructBst();

            var actual = sut.ReconstructTree(input.ToList());

            Assert.Equal(expected, actual.Value);
        }

        [Theory]
        [InlineData(new int[] {10, 15, 8, 12, 94, 81, 5, 2, 11}, new int[] {10, 8, 5, 15, 2, 12, 11, 94, 81})]
        public void ShouldBeTheSameBst(int[] arrayOne, int[]arrayTwo)
        {
            var actual = SameBst.IsSameBst(arrayOne.ToList(), arrayTwo.ToList());

            Assert.True(actual);
        }
    }
}
