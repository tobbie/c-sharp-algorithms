using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class WatchWrapper
    {
        public static long ElapsedTime {
            get {
                return Watch.ElapsedMilliseconds;
            } 
          }
        private static Stopwatch Watch { get; set; }

        public static void Start()
        {
            Watch = new Stopwatch();
            Watch.Start();

        }

        public static void Stop()
        {
            Watch.Stop();
        }
    }
}
