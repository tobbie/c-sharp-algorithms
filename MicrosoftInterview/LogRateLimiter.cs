using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftInterview
{
    public class LogRateLimiter
    {
        private Dictionary<string, int> LogTable { get; set; }
        public LogRateLimiter()
        {
            LogTable = new Dictionary<string, int>();
        }

        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if(!LogTable.ContainsKey(message))
            {
                LogTable.Add(message, timestamp + 10);            
            }
            else
            {
                if (timestamp < LogTable[message])
                    return false;
                LogTable[message] = timestamp + 10;
            }

            return true;
             
        }
    }
}

