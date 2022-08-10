using System.Collections.Generic;
using DataStructures.Graphs.Easy;
using DataStructures.Graphs.Hard;
using DataStructures.Graphs.Medium;
using Xunit;
using MicrosoftInterview;
using DataStructures.Graphs;

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

        [Fact]
        public void ShouldTellGraphHasPath()
        {
            //arrange
            var graph = new Dictionary<char, List<char>>();
            graph.Add('f', new List<char> { 'g', 'i' });
            graph.Add('g', new List<char> { 'h'});
            graph.Add('h', new List<char> {  });
            graph.Add('i', new List<char> { 'g', 'k' });
            graph.Add('j', new List<char> { 'i' });
            graph.Add('k', new List<char> {  });

            //act

            var actual = HasPath.GraphHasPathBFS(graph, 'f', 'k');

            Assert.True(actual);
        }

        [Fact]
        public void ShouldTellGraphHasPath2()
        {
            //arrange
            var graph = new Dictionary<char, List<char>>();
            graph.Add('f', new List<char> { 'g', 'i' });
            graph.Add('g', new List<char> { 'h' });
            graph.Add('h', new List<char> { });
            graph.Add('i', new List<char> { 'g', 'k' });
            graph.Add('j', new List<char> { 'i' });
            graph.Add('k', new List<char> { });

            //act

            var actual = HasPath.GraphHasPathDFS(graph, 'f', 'j');

            Assert.False(actual);
        }

        [Fact]
        public void ShouldTellLargestComponent()
        {
            var graph = new Dictionary<int, List<int>>();
            graph.Add(0, new List<int> { 8, 1, 5 });
            graph.Add(1, new List<int> { 0});
            graph.Add(5, new List<int> { 0, 8});
            graph.Add(8, new List<int> { 0,  5 });
            graph.Add(2, new List<int> { 3, 4});
            graph.Add(3, new List<int> { 2, 4 });
            graph.Add(4, new List<int> { 3, 2 });

            //act
            var largestComp = new LargestComponent();
           int actual = largestComp.GetLargestComponent(graph);
            Assert.Equal(4, actual);
        
        }

        [Fact]
        public void ShouldTellIfWordExists()
        {
            var board = new char[3][];
            board[0] = new char[] { 'A', 'B', 'C', 'E' };
            board[1] = new char[] { 'S', 'F', 'C', 'S' };
            board[2] = new char[] { 'A', 'D', 'E', 'E' };


            var actual = WordSearch.Exists(board, "ABCCED");

            Assert.True(actual);

        }

        [Fact]
        public void ShouldTellIfWordExists3()
        {
            var board = new char[3][];
            board[0] = new char[] { 'A', 'B', 'C', 'E' };
            board[1] = new char[] { 'S', 'F', 'E', 'S' };
            board[2] = new char[] { 'A', 'D', 'E', 'E' };


            // var actual = WordSearch.Exists(board, "ABCESEEEFS");
            var actual = WordSearch.Exists(board, "ABCEFSADEESE");

            Assert.True(actual);

        }


        [Fact]
        public void ShouldTellIfWordExists2()
        {
            var board = new char[3][];
            board[0] = new char[] { 'A', 'B', 'C', 'E' };
            board[1] = new char[] { 'S', 'F', 'C', 'S' };
            board[2] = new char[] { 'A', 'D', 'E', 'E' };


            var actual = WordSearch.Exists(board, "ABCB");

            Assert.False(actual);

        }

        [Fact]
        public void ShouldPrint2DGridWithDFS()
        {
            var grid = new int[4][];
            grid[0] = new int[] { 1, 2, 3, 4 };
            grid[1] = new int[] { 5, 6, 7, 8 };
            grid[2] = new int[] { 9, 10, 11, 12 };
            grid[3] = new int[] { 13, 14, 15, 16 };

            var graphTraversal = new GraphTraversal();
            var actual = graphTraversal.DepthFirstSearchGrid(grid);

            Assert.Equal(16, actual.Length);
        }
    }


}
