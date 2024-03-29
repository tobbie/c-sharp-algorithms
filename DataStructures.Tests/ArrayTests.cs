﻿using Xunit;
using System.Collections.Generic;
using DataStructures.Arrays.Easy;
using DataStructures.Arrays.Medium;

namespace DataStructures.Tests
{
    public class ArrayTests
    {
        [Fact]
        public void ShoudReturnTournamentWinner()
        {
            //arrange
            var competition = new List<List<string>>();
            competition.Add(new List<string> { "HTML", "C#" });
            competition.Add(new List<string> { "C#", "Python" });
            competition.Add(new List<string> { "Python", "HTML" });

            var result = new List<int> { 0, 0, 1 };

            //act

            var actual = TournamentWinner.Winner(competition, result);

            //
            Assert.Equal("Python", actual);
        }

        [Theory]
        [InlineData(new int[] { 5, 7, 1, 1, 2, 3, 22 }, 20)]
        public void TestNonConstructibleChange(int[] array, int expected)
        {
            var actual = NonConstrutibleChange.FindMinimumChange(array);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldMergeOverlappingIntervals()
        {
            // var intervals = new int[][] { new int[] { 1, 2 }, new int[] { 3, 5 }, new int[] { 4, 7 }, new int[] { 6, 8 }, new int[] { 9, 10 } };
            var intervals = new int[][] { new int[] { 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7 }, new int[] { 8, 9 }, new int[] { 1, 10 } };
            var expected = new int[][] { new int[] { 1, 10 }};

            var actual = MergeOverlappingIntervals.Merge(intervals);

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ShouldRotateImage()
        {
            var matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 4, 5, 6 };
            matrix[2] = new int[] { 7, 8, 9 };

            var expected = new int[3][];
            expected[0] = new int[] { 7, 4, 1 };
            expected[1] = new int[] { 8, 5, 2 };
            expected[2] = new int[] { 9, 6, 3 };

            var actual = RotateImage.Rotate(matrix);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void ShouldSetMatrixZeros()
        {
            var matrix = new int[3][];
            matrix[0] = new int[] { 1, 1, 1 };
            matrix[1] = new int[] { 1, 0, 1 };
            matrix[2] = new int[] { 1, 1, 1 };

            var expected = new int[3][];
            expected[0] = new int[] { 1, 0, 1 };
            expected[1] = new int[] { 0, 0, 0 };
            expected[2] = new int[] { 1, 0, 1 };

            var actual = SetMatrixZeros.SetZeros(matrix);
            Assert.Equal(expected, actual);
        }
    }
    
}
