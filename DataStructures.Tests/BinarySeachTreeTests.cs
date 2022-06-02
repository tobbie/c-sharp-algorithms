using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataStructures.Trees.Medium;

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
    }
}
