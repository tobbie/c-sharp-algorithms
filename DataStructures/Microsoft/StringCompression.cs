using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Microsoft
{
    public class StringCompression
    {
        public static int Compress(char[] chars)
        {
            if (chars.Length == 1)
                return 1;

            int count = 1;
            int index = 0;
            string result = string.Empty;
           // var sb = new StringBuilder();
         

            while(index < chars.Length -1)
            {
                if (chars[index] == chars[index + 1])
                    count += 1;
                else
                {
                   result = BuildString(count, result, chars, index);
                   count = 1;
                }

                index += 1;                 
            }

            //add last character and count
           result = BuildString(count, result, chars, chars.Length - 1);

            Array.Copy(result.ToCharArray(), chars, result.Length);
            return result.Length;
        }

        private static string BuildString(int count, string res, char[] chars, int currentIndex)
        {
            if (count == 1)
                res += chars[currentIndex];
            else
            {
                res += $"{chars[currentIndex]}{count}";
            }

            return res;
               
        }

        public static int Compress2(char[] chars)
        {
            if (chars.Length == 1)
                return 1;

            int count = 1;
            int index = 0;
            var result = new StringBuilder();
            // var sb = new StringBuilder();


            while (index < chars.Length - 1)
            {
                if (chars[index] == chars[index + 1])
                    count += 1;
                else
                {
                    result = BuildString2(count, result, chars, index);
                    count = 1;
                }

                index += 1;
            }

            //add last character and count
            result = BuildString2(count, result, chars, chars.Length - 1);

            Array.Copy(result.ToString().ToCharArray(), chars, result.Length);
            return result.Length;
        }

        private static StringBuilder BuildString2(int count, StringBuilder res, char[] chars, int currentIndex)
        {
            if (count == 1)
                res.Append(chars[currentIndex]);
            else
            {
                res.Append($"{chars[currentIndex]}{count}");
            }

            return res;

        }
    }
}
