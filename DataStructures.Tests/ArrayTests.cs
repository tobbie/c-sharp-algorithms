using System;
using Xunit;
using System.Collections.Generic;
using DataStructures.Arrays.Easy;

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
        [InlineData(new int[] {5, 7, 1,  1, 2, 3, 22}, 20)]
        public void TestNonConstructibleChange(int [] array, int expected)
        {
            var actual = NonConstrutibleChange.FindMinimumChange(array);

            Assert.Equal(expected, actual);
        }
    }
    
}
