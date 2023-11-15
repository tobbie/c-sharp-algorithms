using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Algorithms.Search.Easy;
using Algorithms.Search.Medium;
using Algorithms.Search.Hard;

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

        [Theory]
        [InlineData(44, new int[] {3, 3 })]
        public void ShouldFindNumberInSortedMatrix(int target, int[] expected)
        {
            //var actual = BinarySearch.Find(array, target);
            //arrange
            var matrix = new int[,] { { 1, 4, 7, 12, 15, 1000 }, { 2, 5, 19, 31, 32, 1001 }, { 3, 9, 24, 33, 35, 1002 }, { 40, 41, 42, 44, 45, 1003 }, { 99, 100, 103, 106, 128, 1004 } };

            var actual = SearchSortedMatrix.Search(matrix, target);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(245, new int[] { -1, -1 })]
        public void ShouldNotFindNumberInSortedMatrix(int target, int[] expected)
        {
            //var actual = BinarySearch.Find(array, target);
            //arrange
            var matrix = new int[,] { { 1, 4, 7, 12, 15, 1000 }, { 2, 5, 19, 31, 32, 1001 }, { 3, 9, 24, 33, 35, 1002 }, { 40, 41, 42, 44, 45, 1003 }, { 99, 100, 103, 106, 128, 1004 } };

            var actual = SearchSortedMatrix.Search(matrix, target);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 45, 61, 71, 72, 73, 0, 1, 21, 33, 37 }, 33, 8)]
        [InlineData(new int[] { 61, 71, 72, 73, 0, 21, 33, 45, 45 }, 33, 6)]
        public void ShouldUseShiftedBinarySearch(int[] array, int target, int expected)
        {
            var actual = ShiftedBinarySearch.Find(array, target);

            Assert.Equal(expected, actual);
        }

        [Theory]
       // [InlineData(new int[] { 0, 1, 21, 33, 45, 45, 45, 45, 45, 45, 61, 71, 73 }, 45, new int[] {4, 9})]
      //  [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 5, new int[] { 0,0})]
        [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 8, new int[] { 3, 4 })]

        public void ShouldSearchForRange(int[] array, int target, int[] expected)
        {
            var actual = SearchForRange.Find(array, target);

            Assert.Equal(expected, actual);
        }

        [Theory]
         [InlineData(new int[] { 0, 1, 21, 33, 45, 45, 45, 45, 45, 45, 61, 71, 73 }, 45, new int[] {4, 9})]
         [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 5, new int[] { 0,0})]
        [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 8, new int[] { 3, 4 })]

        public void ShouldSearchForRangeOptimally(int[] array, int target, int[] expected)
        {
            var actual = SearchForRange.FindRecrusively(array, target);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 21, 33, 45, 45, 45, 45, 45, 45, 61, 71, 73 }, 45, new int[] { 4, 9 })]
        [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 5, new int[] { 0, 0 })]
        [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 8, new int[] { 3, 4 })]

        public void ShouldSearchForRangeOptimally2(int[] array, int target, int[] expected)
        {
            var actual = SearchForRange.FindIteratively(array, target);

            Assert.Equal(expected, actual);
        }

    //[ 2, 3, 5,6, 7, 8, 9]
        [Theory]
        [InlineData(new int[] {8, 5, 2, 9, 7, 6, 3 }, 3, 5)]
        public void ShouldQuickSelect(int[] array, int k, int expected)
        {
            var actual =  QuickSelect.Find(array, k);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { -5, -3, 2, 3, 4, 5, 9 }, 2)]
        public void ShouldReturnIndexEqualsValue(int[] array,int expected)
        {
            var actual = IndexEqualsValue.Find(array);

            Assert.Equal(expected, actual);
        }





    }
}
