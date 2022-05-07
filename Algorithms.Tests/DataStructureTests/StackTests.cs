﻿using System;
using Xunit;
using DataStructures.Stacks.Medium;

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
        [InlineData(5, 7, 2, 2,7, 1, 5)]
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
    }
}
