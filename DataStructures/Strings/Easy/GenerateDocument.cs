using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings.Easy
{
     public class GenerateDocument
    {
       // O(n + m) time, O(c) space, where c is the no of unique characters, n is the number if charcters in characters, m is the number of characters in document.
        public static bool CanGenerate(string characters, string document)
        {
            //build frequency table of characters
            //check if doucment characters are in frequecncy table
            if (document.Length == 0)
                return true;

            var table  = new Dictionary<char, int>();

            for (int index = 0; index < characters.Length; index++)
            {
                if (table.ContainsKey(characters[index]))
                    table[characters[index]] += 1;
                else
                    table.Add(characters[index], 1);
            }

            for (int j = 0; j < document.Length;  j++)
            {
                if (!table.ContainsKey(document[j]))
                    return false;
                else
                    table[document[j]] -= 1;

                if (table[document[j]] == 0)
                    table.Remove(document[j]);
            }

            return true;
        }
    }
}
