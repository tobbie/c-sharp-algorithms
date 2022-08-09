using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MicrosoftInterview;

namespace Algorithms.Tests
{
   public class MicrosoftInterviewTests
    {
        [Theory]
        [InlineData("1231",'1', "231")]
        [InlineData("551", '5', "51")]
        public void ShouldReturnMaximuzedResult(string input, char digit, string expected)
        {
            var actual = RemoveDigitToMaximizeResult.RemoveDigit(input, digit);
            Assert.Equal(expected, actual);
        }
    }
}
