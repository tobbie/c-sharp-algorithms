using System;
using Xunit;
using DataStructures.Stacks.Medium;
using System.Linq;
using System.Collections.Generic;

namespace Algorithms.Tests.DataStructureTests
{
    public class StackTests
    {
        [Theory]
        [InlineData(5, 2, 7)]


        public void Push(int number1, int number2, int number3) {
            //arrange
            var stack = new MinMaxStack();
            //act

            stack.Push(number1);
            stack.Push(number2);
            stack.Push(number3);

            var actualMin = stack.GetMin();
            var actualMax = stack.GetMax();
            var peekValue = stack.Peek();
            var actualCount = stack.Count();
            //assert

            Assert.Equal(2, actualMin);
            Assert.Equal(7, actualMax);
            Assert.Equal(7, peekValue);
            Assert.Equal(3, actualCount);
        }

        [Theory]
        [InlineData(5, 7, 2, 2, 7, 1, 5)]
        public void ShouldPop(int val1, int val2, int val3, int expected1, int expected2, int expected3, int expected4) {
            //arrange
            var stack = new MinMaxStack();

            //act
            stack.Push(val1);
            stack.Push(val2);
            stack.Push(val3);

            var actual1 = stack.Pop();
            var actual2 = stack.Pop();
            var actual3 = stack.Count();
            var actual4 = stack.GetMax();
            //assert

            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
            Assert.Equal(expected4, actual4);
        }

        [Theory]
        [InlineData(new int[]{3, 5, 4, 4, 3, 1, 3, 2},"WEST", new int[]{0, 1})]
        public void CanSeeSunset( int [] buildings, string direction, int[] exepctedResult) {

            //arrange


            //act
            var actualResult = SunsetViews.Views(buildings, direction);

            //assert
            Assert.Equal(exepctedResult, actualResult);
        }

        [Theory]
        [InlineData(new int[] { 3, 5, 4, 4, 3, 1, 3, 2 }, "EAST", new int[] { 1, 3, 6, 7 })]
        public void CanSeeSunsetEast(int[] buildings, string direction, int[] exepctedResult)
        {

            //arrange


            //act
            var actualResult = SunsetViews.Views(buildings, direction);

            //assert
            Assert.Equal(exepctedResult, actualResult);
        }

        [Theory]
        [InlineData(new int[] {-5, 2, -2, 4, 3, 1 }, new int[] { -5, -2, 1, 2, 3, 4})]
        public void CorrectlySortsStack(int[] inputStack, int[]sortedList)
        {
            //arrange

            //act
            var actualList =  SortStack.Sort(inputStack.ToList());

            //assert
            Assert.Equal(sortedList, actualList.ToArray());

        }

    }
}
