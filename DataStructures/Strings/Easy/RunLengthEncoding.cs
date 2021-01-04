using System;
using System.Text;
using static System.Console;

namespace DataStructures.Strings.Easy
{
    public static class RunLengthEncoding
    {
        private static StringBuilder _result = new StringBuilder();
        private static int _characterCount = 1;

        public static void Run() {
            string input = "AAAAAAAAAAAAABBCCCCDD";
            WriteLine($"Run length encoding is {OptimalSolution2(input)}");
        }

        private static string OptimalSolution(string input) {
            int currentPointer = 0, nextPointer = currentPointer + 1;
            int characterCount = 1;
            var result = new StringBuilder();

            while(currentPointer < (input.Length -1))
            {
                if (input[nextPointer] == input[currentPointer])
                {
                    if (characterCount == 9) 
                        BuildResult();                 
                    else
                        characterCount++;                                   
                }
                else
                    BuildResult();
                   
                currentPointer++;
                nextPointer = currentPointer + 1;
            }

            void BuildResult() {
                result.Append(characterCount);
                result.Append(input[currentPointer]);
                characterCount = 1;
            }

            BuildResult();         
            return result.ToString();

        }


        private static string OptimalSolution2(string input)
        {
            int currentPointer = 0, nextPointer = currentPointer + 1;
            while (currentPointer < (input.Length - 1))
            {
                if (input[nextPointer] == input[currentPointer])
                {
                    if (_characterCount == 9)
                        BuildResult(currentPointer, input);
                    else
                         _characterCount++;
                }
                else
                    BuildResult(currentPointer, input);

                currentPointer++;
                nextPointer = currentPointer + 1;
            }
          
            BuildResult(currentPointer, input);
            return _result.ToString();

        }

        private static void BuildResult(int currentPointer, string input) {
            _result.Append(_characterCount);
            _result.Append(input[currentPointer]);
            _characterCount = 1;
        }
    }
}
