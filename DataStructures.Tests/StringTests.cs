using Xunit;
using DataStructures.Strings.Easy;
using DataStructures.Strings.Meduim;
using DataStructures.Strings.Hard;
using DataStructures.Strings.Microsoft;
using System.Linq;
using DataStructures.Microsoft;

namespace DataStructures.Tests
{
    public class StringTests
    {
        [Theory]
        [InlineData("abcdcaf", 1)]
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

        [Theory]
        [InlineData("1921680", new string[] {"1.9.216.80", "1.92.16.80", "1.92.168.0", "19.2.16.80", "19.2.168.0", "19.21.6.80",
            "19.21.68.0", "19.216.8.0", "192.1.6.80", "192.1.68.0", "192.16.8.0" })]
        public void ShouldReturnValidIps(string input, string[] expected)
        {
            var actual = ValidIPAddresses.Generate(input);
            Assert.Equal(expected.ToList(), actual);
            Assert.Equal(expected.Length, actual.Count);
        }

        [Theory]
        [InlineData("1921680", 11)]
        public void ShouldReturnValidIps2(string input, int expected)
        {
            var actual = ValidIPAddresses.Generate(input);
           
            Assert.Equal(expected, actual.Count);
        }

        [Theory]
        [InlineData(new string[] {"this", "that", "did", "deed", "them!", "a"}, new char[] {'t', 't', 'h', 'i', 's', 'a', 'd', 'd', 'e', 'e', 'm', '!'})]
        public void ShouldReturnMinimumCharacters(string[] words, char[] expected)
        {
            var actual = MinimumCharactersForWords.MinimumCharacters(words);

            Assert.Equal(expected.ToList(), actual.ToList());
        }

        [Theory]
        [InlineData("clementisacap", "mentisac")]
        [InlineData("oluwatobiloba", "luwatobi")]
        public void ShouldReturnLongesSubstring(string input, string expected)
        {
            var sut = new LongestSubstringWithoutDuplication();
            var actual = sut.Find(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
       [InlineData("testthis is a testtest to see if testestest it works", "test", "_test_this is a _testtest_ to see if _testestest_ it works")]
        [InlineData("this is a test to see if it works and test", "test", "this is a _test_ to see if it works and _test_")]
        public void ShouldAddUnderscoresToString(string input, string substring, string expected)
        {
            var actual = UnderscorifySubstring.Underscorify(input, substring);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("xxyxxy", "gogopowerrangergogopowerranger", new string[] {"go", "powerranger"})]
      //  [InlineData("yyxyyx", "gogopowerrangergogopowerranger", new string[] { "go", "powerranger" })]
        [InlineData("xyyx", "powerrangergogopowerranger", new string[] { "powerranger", "go" })]
        public void ShouldMatchStingWithPattern(string pattern,  string input, string[] expected)
        {
            var actual = PatternMatcher.IsMatch(input, pattern);
            Assert.Equal(expected.ToList(), actual);
        }

        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        public void ShouldTellIfStringIsPalindrome(string input, bool expected)
        {
            var actual = ValidPalindrome.IsValid(input);
            
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(" a good   example ", "example good a")]
        public void ShouldReverseWords(string input, string expected)
        {
            var actual = ReverseWordsOne.Reverse(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("    -42", -42)]
        [InlineData("0032", 32)]
        [InlineData("    ", 0)]
        [InlineData("   -", 0)]
        [InlineData("4193 with words", 4193)]
        [InlineData("words and 987", 0)]
        [InlineData("20000000000000000000", int.MaxValue)]

        public void ShouldCovertStringToInteger(string input,int expected)
        {
          var actual =  StringToInterger.ConvertString(input);
            
            

          Assert.Equal(expected, actual);
        }

        [Theory]
     //   [InlineData(new char[] {'t','h','e', ' ', 's', 'k', 'y', ' ', 'i','s', ' ', 'b','l', 'u', 'e'}, new char[] {'b', 'l', 'u', 'e', ' ', 'i', 's', ' ', 's','k', 'y', ' ', 't', 'h', 'e'})]
        [InlineData(new char[] {'h','i'}, new char[] { 'h', 'i' })]
        public void ShouldReverseWord2(char[] input, char[] expected)
        {
            var actual = ReverseWordsTwo.Reverse(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("abaxyzzyxf", "xyzzyx")]
        public void ShouldReturnLongestPlaindromicSubString(string input, string expected)
        {
            var actual = PalindromicSubstring.LongestPalindoromeSubString(input);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("scpcyxprxxsjyjrww", 42)]
        [InlineData("kayka", 1)]
        public void ShouldReturnMinumumPalindromSwaps(string input, int expected)
        {
            var actual = MimumumSwapsPalindrome.MinimumSwaps(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
      //  [InlineData("3+2*2", 7)]
        //[InlineData("4  2", 42)]
        [InlineData("53", 53)]
        public void ShouldDoBasicCalculation(string input, int expected)
        {
            var actual = BasicCalculator2.Calculate(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("3+2*2", 7)]
        [InlineData("4  2", 42)]
        [InlineData("53", 53)]
        [InlineData("1+2 *3 -5/4", 6)]
        public void ShouldDoBasicCalculation2(string input, int expected)
        {
            var actual = BasicCalculator2.CalculateOptimal(input);
            Assert.Equal(expected, actual);
        }

    }
}
