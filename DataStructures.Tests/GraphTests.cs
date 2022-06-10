using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Graphs;
using Xunit;

namespace DataStructures.Tests
{
   public class GraphTests
    {
        [Fact]
        public void ShouldTestIslands()
        {
            //arrange
            var input = new int[6][];
            input[0] = new int[] { 1, 0, 0, 0, 0, 0 };
            input[1] = new int[] { 0, 1, 0, 1, 1, 1 };
            input[2] = new int[] { 0, 0, 1, 0, 1, 0 };
            input[3] = new int[] { 1, 1, 0, 0, 1, 0 };
            input[4] = new int[] { 1, 0, 1, 1, 0, 0 };
            input[5] = new int[] { 1, 0, 0, 0, 0, 1 };




            //act

            RemoveIslands.Remove(input);
            //assert

            Assert.True(true);
       }


        [Fact]
        public void ShouldReturnNumberOfIslands()
        {
            //arrange
            var input = new int[6][];
            input[0] = new int[] { 1, 0, 0, 0, 0, 0 };
            input[1] = new int[] { 0, 1, 0, 1, 1, 1 };
            input[2] = new int[] { 0, 0, 1, 0, 1, 0 };
            input[3] = new int[] { 1, 1, 0, 0, 1, 0 };
            input[4] = new int[] { 1, 0, 1, 1, 0, 0 };
            input[5] = new int[] { 1, 0, 0, 0, 0, 1 };




            //act

            var actual = NumberOfIslands.FindIslands(input);
            //assert

            Assert.Equal(7, actual);
        }
    }


}
