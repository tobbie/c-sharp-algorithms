using System;
using Arrays.Medium;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace AlgorithimsPractise.Tests.ArrayTests
{
    public class ArrayManipulationTests
    {
        public ArrayManipulationTests()
        {
        }

        [Fact]
        public void ShoudldReturnTwoElementArrayWithSmallestAbsoluteDifference() {
            //Arrange
            int[] array1 = new int [] { -1, 5, 10, 20, 28, 3 };
            int[] array2 = new int[] { 26, 134, 135, 15, 17};
            int[] expectedResult = new int[] { 28, 26 };

            //Act

            var actualResult = SmallestDifferencePractise.SmallestDifference(array1, array2);

            //Assert
            Assert.Equal(expectedResult[0], actualResult[0]);
            Assert.Equal(expectedResult[1], actualResult[1]);
            Assert.Equal(actualResult.Length, expectedResult.Length);

        }

        [Fact]
        public void ShouldMoveElementToEnd() {
            //Arrange
            var inputArray = new List<int> { 2, 1, 2, 2, 2, 3, 4, 2 };
            int toMove = 2;
            int numberOfElementsToMove = inputArray.Where(x => x == toMove).Count();
            int startingIndex = inputArray.Count - numberOfElementsToMove;

            //Act
            var resultArray = MoveElementToEndPractice.MoveElementToEnd(inputArray, toMove);

            //Assert

            while (startingIndex < inputArray.Count) {
                Assert.Equal(resultArray[startingIndex], toMove);
                startingIndex++;
            }
        }
    }
}
