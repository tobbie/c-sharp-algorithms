using System;
using System.Collections.Generic;
using Common;

namespace Algorithms.Recursion.Medium
{
    public static class Mnemonics
    {
        private static readonly Dictionary<char, IEnumerable<string>> Digit_Letters
            = new Dictionary<char, IEnumerable<string>>()
            {
                {'1', new List<string> { "1" } },
                {'2', new List<string> { "a", "b", "c"}},
                {'3', new List<string> { "d", "e", "f" }},
                {'4', new List<string> { "g", "h", "i" } },
                {'5', new List<string> { "j" , "k", "l" } },
                {'6', new List<string> { "m", "n", "o" } },
                {'7', new List<string> { "p", "q", "r", "s" } },
                {'8', new List<string> { "t", "u", "v" } },
                {'9', new List<string> { "w", "x", "y", "z" } },
                {'0', new List<string> { "0" } },


            };
        public static void Run() {
            var phoneNo = "444";
            var result = PhoneNumberMnemonic(phoneNo);
            Util.PrintList(result);
        }

        private static IEnumerable<string> PhoneNumberMnemonic(string phoneNumber)
        {       
            if(string.IsNullOrWhiteSpace(phoneNumber))
                return new List<string>();

            var mnemonicsFound = new List<string>();
            var currentMnemonic = new List<string>();
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                currentMnemonic.Add("0");
            }

            PhoneNumberMnemonicsHelper(0, currentMnemonic, phoneNumber, mnemonicsFound);
            return mnemonicsFound;
        }

        //phone = 1905
        private static void PhoneNumberMnemonicsHelper(int index, List<string> currentMnemonic, string phoneNumber, List<string> mnemonicsFound)
        {
            if (index == phoneNumber.Length)
                mnemonicsFound.Add(string.Join("", currentMnemonic));
            else {
                var digit = phoneNumber[index];
                var characters = Digit_Letters[digit];
                foreach (var item in characters)
                {
                    currentMnemonic[index] = item;
                    PhoneNumberMnemonicsHelper(index + 1, currentMnemonic, phoneNumber, mnemonicsFound);
                }
            }
                
        }
    }
}
