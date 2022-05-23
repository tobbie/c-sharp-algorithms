using System;
using Algorithims.Sort.Easy;
using Algorithims.Sort.Hard;
using Algorithims.Sort.VeryHard;
using Algorithims.Sort.Medium;
using Xunit;
using System.Linq;

namespace Algorithms.Tests
{
   public class SortingTests
    {
        [Theory]
        [InlineData(new int[] {8, 5, 2, 9, 5, 6, 3}, new int[] {2, 3, 5, 5, 6, 8, 9})]
        public void ShouldBubbleSort(int [] inputArray,int[] expected)
        {
            //act
            var actual = BubbleSort.Sort(inputArray);

            Assert.Equal(expected.ToList(), actual.ToList());
        }

        [Theory]
        [InlineData(new int[] { 8, 5, 2, 9, 5, 6, 3 }, new int[] { 2, 3, 5, 5, 6, 8, 9 })]
        [InlineData(new int[] { 7, 5, 2, 9, 6, 4, 3 }, new int[] { 2, 3, 4, 5, 6, 7, 9 })]
        public void ShouldInsertionSort(int[] inputArray, int[] expected)
        {
            //act
            var actual = InsertionSort.Sort(inputArray);

            Assert.Equal(expected.ToList(), actual.ToList());
        }

        [Theory]
        [InlineData(new int[] { 8, 5, 2, 9, 5, 6, 3 }, new int[] { 2, 3, 5, 5, 6, 8, 9 })]
        [InlineData(new int[] { 7, 5, 2, 9, 6, 4, 3 }, new int[] { 2, 3, 4, 5, 6, 7, 9 })]
        public void ShouldUseSelectionSort(int[] inputArray, int[] expected)
        {
            //act
            var actual = SelectionSort.Sort(inputArray);

            Assert.Equal(expected.ToList(), actual.ToList());
        }

        [Theory]
        [InlineData(new int[] { 8, 5, 2, 9, 5, 6, 3 }, new int[] { 2, 3, 5, 5, 6, 8, 9 })]
        [InlineData(new int[] { 6, 5, 8, 7, 9, 10, 1, 4, 3, 2 }, new int[] { 1, 2, 3, 4, 5, 6 ,7 , 8, 9, 10})]
        public void ShouldUseQuickSort(int[] inputArray, int[] expected)
        {
            //act
            var actual = QuickSort.Sort(inputArray);

            Assert.Equal(expected.ToList(), actual.ToList());
        }

        [Theory]
        [InlineData(new int[] { 8, 5, 2, 9, 5, 6, 3 }, new int[] { 2, 3, 5, 5, 6, 8, 9 })]
        [InlineData(new int[] { 6, 5, 8, 7, 9, 10, 1, 4, 3, 2 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void ShouldUseMergeSort(int[] inputArray, int[] expected)
        {
            //act
            var actual = MergeSort.DoMergeSort(inputArray);

            Assert.Equal(expected.ToList(), actual.ToList());
        }

        [Theory]
        [InlineData(new int[] {1, 0, 0, -1, -1, 0, 1, 1 }, new int[] {0, 1, -1}, new int[] {0, 0, 0, 1, 1, 1, -1, -1})]
        [InlineData(new int[] { 9,9, 9, 7, 9, 7, 9, 9, 7, 9 }, new int[] { 11, 7, 9}, new int[] { 7, 7, 7, 9, 9, 9, 9, 9, 9 ,9 })]
        [InlineData(new int[] { 6,6,6,6,6,6,6,6,6,6,6,6}, new int[] { 4, 5, 6 }, new int[] { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 })]
        [InlineData(new int[] { 1 }, new int[] { 0, 1, 2 }, new int[] { 1 })]
        public void ShouldDoThreeNumberSort(int [] array, int[] order, int[] expected)
        {
            var actual = ThreeNumberSort.Sort(array, order);

            Assert.Equal(expected, actual);
        }
    }
}
