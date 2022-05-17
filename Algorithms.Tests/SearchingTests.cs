using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Algorithims.Search.Easy;

namespace Algorithms.Tests
{
   public class SearchingTests
    {
        [Theory]
        [InlineData(new int []{ 0, 1, 21, 33, 45, 45, 61, 71, 72, 73}, 33, 3)]
        [InlineData(new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 }, 74, -1)]
        public void ShouldFindNumber(int [] array, int target,int expected)
        {
            var actual = BinarySearch.Find(array, target);

            Assert.Equal(expected, actual);
        }
    }
}
