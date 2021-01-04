using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Linq;

namespace DataStructures.Strings.Easy
{
    public class CeaserCipherEncryptor
    {
        private const int MaxAlphabets = 26;
        public CeaserCipherEncryptor()
        {
        }

        public static void Run() {
           WriteLine(OptimalSolution2("abc", 57));
        }

        private static string OptimalSolution(string str, int key) {

            if (string.IsNullOrEmpty(str))
                return string.Empty;

            var alphabetDict = new Dictionary<string,int>();
            var alphabetPositionDict = new Dictionary<int, string>();
            int alphabetPosition = 1;
            var resultBuilder = new StringBuilder();
            for (int index = 65; index <= 90 ; index++)
            {
                alphabetDict.Add(ConverFromAsciiToChar(index), alphabetPosition);
                alphabetPositionDict.Add(alphabetPosition, ConverFromAsciiToChar(index).ToLower());
                alphabetPosition++;
            }

            for (int index = 0; index < str.Length; index++)
            {
                int currentPosition = alphabetDict[str[index].ToString()];
                int newPosition = GetNewPosition(currentPosition, key);
                resultBuilder.Append(alphabetPositionDict[newPosition]);
            }

            return resultBuilder.ToString();
        }

        private static string ConverFromAsciiToChar(int code) {

            return ((char)code).ToString();
        }

        private static int GetNewPosition(int currentPosition, int key) {
            int position = currentPosition + key;
            return position > MaxAlphabets ? position % MaxAlphabets : position;
        }

        private static string OptimalSolution2(string str, int key) {
            var result = new StringBuilder();
            for (int index = 0; index < str.Length; index++)
            {
                int currentPosition = str[index];
                int newPosition = ComputeNewPosition(currentPosition, key);
                result.Append(ConverFromAsciiToChar(newPosition));
            }
            return result.ToString();
        }

        private static int ComputeNewPosition(int currentPosition, int key) {
            int maxPosition = 'z';
            int minPosition = 'a';

            if (key > MaxAlphabets)
                key = key % MaxAlphabets;

            int newPosition = currentPosition + key;

            return newPosition > maxPosition ? minPosition + (newPosition - maxPosition) - 1 : newPosition;
        }
    }
}
