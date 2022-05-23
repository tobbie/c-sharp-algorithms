
using DataStructures.Stacks.Medium;
using Xunit;
using DataStructures.Stacks.Hard;
using System.Linq;

namespace DataStructure.Tests
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

        [Theory]
        [InlineData(new int[] {2, 5, -3, -4, 6, 7, 2 }, new int[] {5, 6, 6, 6, 7, -1, 5 })]
        public void ShouldFindNextGreaterThan(int [] array, int[] expected) {
            //arrange

            //act
            var actual = NextGreaterThan.FindNexGreaterThan(array);

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("/foo/../test/../test/../foo//bar/./baz", "/foo/bar/baz")]
        [InlineData("foo/../..", "..")]
        [InlineData("./..", "..")]
        [InlineData("/foo/bar/..", "/foo")]
        [InlineData("/foo/bar/baz/././.", "/foo/bar/baz")]
        [InlineData("../../foo/bar/baz", "../../foo/bar/baz")]
        [InlineData("/../../foo/../../bar/baz", "/bar/baz")]
        [InlineData("../../../this////one/./../../is/../../going/../../to/be/./././../../../just/eight/double/dots/../../../../../..", "../../../../../../../..")]
        public void TestShortenPath(string path, string expected)
        {
            var actual = ShortenPath.Shorten(path);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("/", "/")]
        [InlineData("/foo/../test/../test/../foo//bar/./baz", "/foo/bar/baz")]
        [InlineData("foo/../..", "..")]
        [InlineData("./..", "..")]
        [InlineData("/foo/bar/..", "/foo")]
        [InlineData("/foo/bar/baz/././.", "/foo/bar/baz")]
        [InlineData("../../foo/bar/baz", "../../foo/bar/baz")]
        [InlineData("/../../foo/../../bar/baz", "/bar/baz")]
        [InlineData("../../../this////one/./../../is/../../going/../../to/be/./././../../../just/eight/double/dots/../../../../../..", "../../../../../../../..")]

        public void TestShorten2Path(string path, string expected)
        {
            var actual = ShortenPath.Shorten2(path);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] {1, 3, 3, 2, 4, 1, 5, 3, 2 }, 9)]
        [InlineData(new int[] { 2, 1, 2 }, 3)]
        public void ShouldReturnLargestRectangleArea(int []buildings, int expected)
        {
            //arrange

            //act
            var actual = LargestRectangleUnderSkyline.LargestRectangleArea(buildings);

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 3, 2, 4, 1, 5, 3, 2 }, 9)]
        [InlineData(new int[] { 2, 1, 2 }, 3)]
        public void ShouldReturnLargestRectangleArea2(int[] buildings, int expected)
        {
            //arrange

            //act
            var actual = LargestRectangleUnderSkyline.LargestRectangleArea2(buildings.ToList());
            //assert
            Assert.Equal(expected, actual);
        }

    }
}
