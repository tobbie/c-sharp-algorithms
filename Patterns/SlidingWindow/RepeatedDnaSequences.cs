using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SlidingWindow
{
    public static class RepeatedDnaSequences
    {
        public static string[] FindRepeatedSequences(string input, int k)
        {
            if (input.Length <= k)
                return new string[] { };

            var result = new HashSet<string>();
            var subsequenceSet = new HashSet<string>();
           
            int startIndex = 0;
            int endIndex = k -1;
            using var sha256 = SHA256.Create();
            while(endIndex < input.Length)
            {
               string currentSequence = input.Substring(startIndex,k);
                var hashedStringBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(currentSequence));
              
                if (subsequenceSet.Contains(Convert.ToBase64String(hashedStringBytes)))
                    result.Add(currentSequence);
                else
                {
                    subsequenceSet.Add(Convert.ToBase64String(hashedStringBytes));
                }

                startIndex++;
                endIndex++;

            }

            return result.Reverse().ToArray();
        }
    }
}
