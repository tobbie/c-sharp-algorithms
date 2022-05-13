using System;
using System.Collections.Generic;


namespace DataStructures.Strings.Easy
{
    public class NonRepeatingCharacter
    {
        public static int FirstNonRepeatingCharacter(string input)
        {
            var frequencyTable = new Dictionary<char, int>();
            for(int i = 0; i < input.Length; i++)
            {
                if (frequencyTable.ContainsKey(input[i]))
                    frequencyTable[input[i]] += 1;
                else
                    frequencyTable.Add(input[i], 1);
            }

            for (int j = 0;  j < input.Length; j++)
            {
                if (frequencyTable[input[j]] == 1)
                    return j;
            }

            return -1;
        }
    }
}
