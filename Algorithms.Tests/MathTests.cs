using System;
using Xunit;
using MicrosoftInterview;

namespace Algorithms.Tests
{
    public class MathTests
    {
        [Theory]
        [InlineData("123", "456", "56088")]
        [InlineData("2", "3", "6")]
        public void ShouldMultilyStrings(string num1, string num2, string expected)
        {
            //arrange
            var sut = new MultiplyStrings();
            var actual = sut.Multiply(num1, num2);

            Assert.Equal(expected, actual);

        }
    }
}
