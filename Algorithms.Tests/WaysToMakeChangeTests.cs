﻿using System;
using Xunit;
using Algorithims.DynamicProgramming.Medium;

namespace Algorithms.Tests
{
  public class WaysToMakeChangeTests
    {
        [Fact]
        public void ShouldReturn2() 
        {
            //arrange
            int n = 6;
            var denominations = new int[] { 1, 5 };


            //act
            var actual = NumberOfWaysToMakeChange.MakeChange(n, denominations);

            //assert

            Assert.Equal(2, actual);
        }

        [Fact]
        public void ShouldReturn4()
        {
            //arrange
            int n = 10;
            var denominations = new int[] { 1, 5, 10, 25 };


            //act
            var actual = NumberOfWaysToMakeChange.MakeChange(n, denominations);

            //assert

            Assert.Equal(4, actual);
        }
    }
}