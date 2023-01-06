using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.SlidingWindow
{
    public class MinimumWindowSubsequence
    {
        public static string MinimumWindow(string str1, string str2)
        {
            int indexString1 = 0, indexString2 = 0;
            int startIndex =0, endIndex = 0;
            double length = Double.PositiveInfinity;
            string minimumString = string.Empty;
            

            while (indexString1 < str1.Length)
            {
                //find out if the substring is contained in the main string.
                if (str1[indexString1] == str2[indexString2])
                {             
                    indexString2++;

                    //find out how long the subequence is by doing a reverse loop. 
                    // detremine if current substring length is the minimum 
                    // update length and minimum string;
                    // repeat process
                    if (indexString2 == str2.Length)
                    {
                        indexString2 = str2.Length - 1;
                        startIndex = indexString1;
                        endIndex = startIndex + 1;

                        while (indexString2 >= 0)
                        {
                            if (str1[startIndex] == str2[indexString2])
                            {
                                indexString2--;
                                startIndex--;
                            }
                            else
                            {
                                startIndex--;
                            }
                        }

                        startIndex += 1;
                        indexString2 += 1;
                        int currentMinimumLength = endIndex - startIndex;

                        if (length > (currentMinimumLength))
                        {
                            length = currentMinimumLength;
                            minimumString = str1.Substring(startIndex, currentMinimumLength);
                        }

                        indexString1 = startIndex + 1;
                    }
                }                               
                indexString1++;              
            }

            return minimumString;

        }
    }
}
