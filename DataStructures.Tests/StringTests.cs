using System;
using Xunit;
using DataStructures.Strings.Easy;

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

    }
}
