using System;
using Xunit;
using System.Collections.Generic;
using Algorithims.Greedy.Easy;

namespace Algorithms.Tests
{
    public class ClassPhotosTests
    {
        [Fact]
        public void ShouldReturnTrue()
        {
            //Arrange
            var blueShirts = new List<int>() {5, 8, 1, 3, 4 };
            var redShirts = new List<int>() {6, 9, 2, 4, 5 };

            //Act
            var actual = ClassPhotos.CanTakePhotos(redShirts, blueShirts);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            //Arrange
            var blueShirts = new List<int>() { 5, 8, 1, 3, 4 };
            var redShirts = new List<int>() { 5, 9, 2, 4, 5 };

            //Act
            var actual = ClassPhotos.CanTakePhotos(redShirts, blueShirts);

            //Assert
            Assert.False(actual);
        }
    }
}
