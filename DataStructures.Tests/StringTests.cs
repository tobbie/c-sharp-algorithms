using System;
using Xunit;
using DataStructures.Strings.Easy;
using DataStructures.Strings.Meduim;

namespace DataStructures.Tests
{
   public class StringTests
    {
        [Theory]
        [InlineData("abcdcaf", 1 )]
        public void ShoudReturnFirstNonRepeatingCharacter(string input, int expected)
        {
            var actual = NonRepeatingCharacter.FirstNonRepeatingCharacter(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Bste!hetsi ogEAxpelrt x ", "AlgoExpert is the Best!")]
        public void ShouldGenerateDocumentTests(string characters, string document)
        {
            var actual = GenerateDocument.CanGenerate(characters, document);

            Assert.True(actual);
        }

        [Theory]
        [InlineData("abcabc", "aabbccc")]
        public void ShouldNotGenerateDocumentTests(string characters, string document)
        {
            var actual = GenerateDocument.CanGenerate(characters, document);

            Assert.False(actual);
        }


        [Theory]
        [InlineData("AlgoExpert is the best!", "best! the is AlgoExpert")]
        [InlineData("4    whitespaces", "whitespaces    4")]
        public void ShouldReverseString(string inputString, string expected)
        {
            var actual = ReverseWords.Reverse(inputString);

            Assert.Equal(expected, actual);
        }

    }
}
