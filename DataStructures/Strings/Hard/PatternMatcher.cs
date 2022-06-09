using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings.Hard
{
    public class PatternMatcher
    {
        public static List<string> IsMatch(string str, string pattern)
        {
          
            var newPattern = GetPatternList(pattern);
            bool didSwitch = newPattern[0] != pattern[0];
            var patternCount = new Dictionary<char, int>();
            patternCount.Add('x', 0);
            patternCount.Add('y', 0);




            int? firstYPosition = GetPatternCountAndFirstYPosition(patternCount, newPattern);

            if (patternCount['y'] != 0)
            {
                for (int lenOfX = 1; lenOfX <= str.Length; lenOfX++)
                {
                    var lenOfY = (str.Length - (lenOfX * patternCount['x']) )/ patternCount['y'];
                    if (lenOfY <= 0 || lenOfY % 1 != 0)
                        continue;
                    lenOfY = Convert.ToInt32(lenOfY);

                    var yIndex = (int)firstYPosition * lenOfX;

                    var xWord = str.Substring(0, lenOfX);
                    var yWord = str.Substring(yIndex, lenOfY);

                    var potentialMatch = newPattern
                                        .Select(item => item == 'x' ? xWord : yWord)
                                        .ToList();

                    if (str == string.Join("", potentialMatch))
                        return didSwitch == false ? new List<string>() { xWord, yWord } : new List<string>() { yWord, xWord };
                }               
            }
            else
            {
                var lenOfX = str.Length / patternCount['x'];
                if (lenOfX % 1 == 0)
                {
                    lenOfX = Convert.ToInt32(lenOfX);
                    var xWord = str.Substring(0, lenOfX);
                    var potentialMatch = newPattern.Select(item => xWord).ToList();
                    if (str == string.Join("", potentialMatch))
                        return didSwitch == false ? new List<string> { xWord, string.Empty } : new List<string> { string.Empty, xWord };
                }
            }
            return new List<string>();
        }

        private static int? GetPatternCountAndFirstYPosition(Dictionary<char, int> patternCount, List<char> pattern)
        {
            int? firstYPosition = null;
            for (int i = 0; i < pattern.Count; i++)
            {
                patternCount[pattern[i]] += 1;

                if (pattern[i] == 'y' && firstYPosition == null)
                    firstYPosition = i;
            }

            return firstYPosition;
        }

        private static List<char> GetPatternList(string pattern)
        {
            if (pattern[0] == 'x')
                return pattern.ToList();
            else
                return pattern.Select(item => item == 'y' ? 'x' : 'y').ToList();
        }

       //static Func<char, char> Reverse = item => item == 'y' ? 'x' : 'y';
    }
}
