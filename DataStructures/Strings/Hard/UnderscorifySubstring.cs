using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Strings.Hard
{
    public class UnderscorifySubstring
    {
        public static string Underscorify(string str, string subString)
        {
            //getLocations
            //collapseLocations
            var locations = CollapseLocations(GetLocations(str, subString));            
            return InserUnderscores(str, locations);
        }

        private static List<List<int>> GetLocations(string str, string subString)
        {
            var locations = new List<List<int>>();
            int startIndex = 0;
            while (startIndex < str.Length)
            {
                int nextIndex = str.IndexOf(subString, startIndex);
                if (nextIndex != -1)
                {
                    locations.Add(new List<int> { nextIndex, nextIndex + subString.Length });
                    startIndex = nextIndex + 1;
                }
                else
                    break;
            }
            return locations;
        }

        private static List<List<int>> CollapseLocations(List<List<int>> locations)
        {
            if (!locations.Any())
                return locations;

            var newLocations = new List<List<int>>();
            newLocations.Add(locations[0]);

            var previous = newLocations[0];

            for (int i = 1; i < locations.Count; i++)
            {
                var current = locations[i];
                if (current[0] <= previous[1])
                {
                    previous[1] = current[1];
                }
                else
                {
                    newLocations.Add(current);
                    previous = current;
                }          
            }
            return newLocations;
        }

        private static string InserUnderscores(string str, List<List<int>> locations)
        {
            if (!locations.Any())
                return str;

            var result = new List<char>();
            int stringIndex = 0;
            int locationIndex = 0;
            int index = 0;
            bool inBetweenUnderscores = false;

            while(stringIndex < str.Length && locationIndex < locations.Count)
            {
                if (stringIndex == locations[locationIndex][index])
                {
                    result.Add('_');
                    inBetweenUnderscores = !inBetweenUnderscores;
                    if (!inBetweenUnderscores)
                        locationIndex += 1;

                    index = index == 1 ? 0 : 1;
                }
                result.Add(str[stringIndex]);
                stringIndex++;
            }

            if (locationIndex < locations.Count)
                result.Add('_');
            else if (stringIndex < str.Length)
                result.AddRange(str[stringIndex..]);
            
            return string.Join("", result);
        }
    }
}
