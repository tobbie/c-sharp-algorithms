using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Patterns.FastAndSlow;

namespace Algorithms.Tests
{
    public class FastAndSlowTests
    {
        [Theory]
        [InlineData(new int[] {1, 3, -2, -4, 1}, true)]
        [InlineData(new int[] { 2, 1, -1, -2, 2 }, false)]
        [InlineData(new int[] { 5, -4, -3, -2, -1 }, true)]
        [InlineData(new int[] { 2, -1, 1, 2, 2 }, true)]
        public void ShouldFindCycleInArray(int[] array, bool expected)
        {
           bool actual = CircularArray.HasLoop(array);
            Assert.Equal(expected, actual);
        }
    }
}
