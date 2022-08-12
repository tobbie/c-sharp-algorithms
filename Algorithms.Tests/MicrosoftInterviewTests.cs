
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

        [Theory]
        //[InlineData("/", "/a/b/c", "/a/b/c/d,hello", "/", "/a/b/c/d")]
        [InlineData("/zijzllb", "/", "/zijzllb", "/r","/", "/r", "/zijzllb/hfktg, d", "/zijzllb/hfktg", "/", "/zijzllb/hfktg")]

        public void ShouldBuildFileSystem(string mkdir, string ls, string ls2, string mkdir2, string ls3, string ls4,
            string addContentToFile, string readContentFromFile, string ls5, string readContentFromFile2)
        {
            var fs = new FileSystem();
           
            fs.Mkdir(mkdir);
            var res1 = fs.Ls(ls);
            var res2 = fs.Ls(ls2);

            fs.Mkdir(mkdir2);
            var res3 = fs.Ls(ls3);
            var res4 = fs.Ls(ls4);

            var content = addContentToFile.Split(',');

            fs.AddContentToFile(content[0], content[1]);

         
            var readResult = fs.ReadContentFromFile(readContentFromFile);

            var res5 = fs.Ls(ls5);
            var readRes = fs.ReadContentFromFile(readContentFromFile2);

            Assert.True(true);

        }

        [Theory]
        [InlineData(123, "One Hundred Twenty Three")]
        public void ConvertIntegerToEnglish(int input, string expected)
        {
            var sut = new IntegerToEnglishWords();
            var actual = sut.NumberToWords(input);
            Assert.Equal(expected, actual);
        }
    }
}
