using DataStructures.Arrays.Easy;
using DataStructures.Arrays.Medium;
using DataStructures.Arrays.Neetcode;
using System.Collections.Generic;
using Xunit;


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
            var expected = new int[][] { new int[] { 1, 10 } };

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

        [Theory]
        [InlineData(new int[] { 5, 7, 1, 1, 2, 3, 22 })]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 })]
        public void ShouldDetectDuplicate(int[] array)
        {
            var actual = ContainsDuplicate.HasDuplicate(array);

            Assert.True(actual);
        }

        [Theory]
        [InlineData(new int[] { 5, 7, 1, 2, 3, 22 })]
        public void ShouldNotDetectDuplicate(int[] array)
        {
            var actual = ContainsDuplicate.HasDuplicate(array);

            Assert.False(actual);
        }


        [Theory]
        [InlineData("top", "pot")]
        [InlineData("tops", "pots")]
        [InlineData("anagram", "nagaram")]
        [InlineData("nnode", "donne")]
        public void IsValidAnagram(string first, string second)
        {
            var expected = ValidAnagram.IsAnagram(first, second);
            Assert.True(expected);
        }

        [Theory]
        [InlineData("tope", "pot")]
        [InlineData("tops", "pota")]
        [InlineData("anagram", "nagarams")]
        [InlineData("rat", "car")]
        public void IsNotValidAnagram(string first, string second)
        {
            var expected = ValidAnagram.IsAnagram(first, second);
            Assert.False(expected);
        }

        [Theory]
        [InlineData(new int[] { 5, 7, 1, 2, 8, 4, 3 }, 10)]
        public void ShouldReturnTrueIfTwoSumExist(int[] array, int target)
        {
            var actual = TwoSum.TwoSumBoolean(array, target);

            Assert.True(actual);
        }

        [Theory]
        [InlineData(new int[] { 5, 7, 1, 19, 8, 4, 20 }, 10)]
        public void ShouldReturnFalseIfTwoSumDoesNotExist(int[] array, int target)
        {
            var actual = TwoSum.TwoSumBoolean(array, target);

            Assert.False(actual);
        }

        [Theory]
        [InlineData("  Hello World  ", "World Hello")]
        [InlineData("I am sam ", "sam am I")]
        [InlineData("  The quick brown fox jumped over the lazy dog", "dog lazy the over jumped fox brown quick The")]


        public void ShouldReverseWord(string word, string expected)
        {
            var actual = ReverseWords.Reverse(word);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 1, 1, 2, 2, 3, 3, 4 }, 2, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 4, 1, -1, 2, -1, 2, 3 }, 2, new int[] { -1, 2 })]
        public void ShouldReturnTopKElements(int[] array, int k, int[] expected)
        {
            var actual = TopKFrequentElements.TopKElements(array, k);
            Assert.Equal(expected, actual);


        }

        //Generate tests for MaxPlankSum
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, -1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, -1)]
        [InlineData(new int[] { 9, 2, 3, 4, 5, 6, 7 }, 16)]
        [InlineData(new int[] { 20, 2, 3, 4, 5, 6, 7, 8 }, 28)]
        public void ShouldReturnMaxPlankSum(int[] array, int expected)
        {
            var maxPlankSum = new MaxPlankSum();
            var actual = maxPlankSum.MaxSum(array);
            Assert.Equal(expected, actual);
        }





    }

}
