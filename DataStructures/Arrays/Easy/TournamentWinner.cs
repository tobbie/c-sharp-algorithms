using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Easy
{
   public class TournamentWinner
    {
     
        public static string Winner(List<List<string>> competitors, List<int> results)
        {
            var points = new Dictionary<string, int>();

            var winner = new Winner();

            for(int i = 0; i < competitors.Count; i++)
            {
                if(results[i] == 0 && points.ContainsKey(competitors[i][1]))
                {
                    points[competitors[i][1]] += 3;
                    ComputeWinner(competitors[i][1], points[competitors[i][1]], ref winner);
                   
                }
                else if(results[i] == 0)
                {
                    points.Add(competitors[i][1], 3);
                    ComputeWinner(competitors[i][1], 3, ref winner);
                }
                else if(results[i] == 1 && points.ContainsKey(competitors[i][0]))
                {
                    points[competitors[i][0]] += 3;
                    ComputeWinner(competitors[i][0], points[competitors[i][0]], ref winner);
                }
                else if (results[i] == 1)
                {
                    points.Add(competitors[i][0], 3);
                    ComputeWinner(competitors[i][0], 3, ref winner);
                }


            }

            return winner.Name;
        }

        private static void ComputeWinner(string key, int value, ref Winner winner)
        {
            if(value > winner.MaxValue)
            {
                winner.Name = key;
                winner.MaxValue = value;
            }      
        }

        
    }

    public class Winner
    {
        public string Name { get; set; }
        public int MaxValue { get; set; }
    }
}
