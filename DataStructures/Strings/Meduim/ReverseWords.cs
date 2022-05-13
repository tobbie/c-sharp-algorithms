using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings.Meduim
{
   public class ReverseWords
    {
        //(O(n + m) or O(n) time, O(m) space 
        public static string Reverse(string str)
        {
            if (str.Length == 0 || str.Length == 1)
                return str;
            //split string
            var stringList = Split(str);
            return ReverseStrings(stringList);
        }

        private static string ReverseStrings(List<string> stringList)
        {
            int leftPointer = 0;
            int rightPointer = stringList.Count - 1;

            while(leftPointer < rightPointer)
            {
                var temp = stringList[leftPointer];
                stringList[leftPointer] = stringList[rightPointer];
                stringList[rightPointer] = temp;
                leftPointer++;
                rightPointer--;

            }

           return string.Join("", stringList);

        }

        private static List<string> Split(string inputString)
        {
            if (inputString.Length == 0 || inputString.Length == 1)
                return new List<string>();

            var stringList = new List<string>();
            var builder = new StringBuilder();

            for (int index = 0; index < inputString.Length; index++)
            {
                if(inputString[index] == ' ' && builder.Length > 0 )
                {
                    stringList.Add(builder.ToString());
                    stringList.Add(inputString[index].ToString());
                    builder.Clear();
                }
                else if(inputString[index] == ' ')
                {
                    stringList.Add(inputString[index].ToString());
                }
                else
                {
                    builder.Append(inputString[index]);
                }
            }

            if (builder.Length > 0)
            {
                stringList.Add(builder.ToString());           
                builder.Clear();
            }
               

            return stringList;
        }

    }
}
