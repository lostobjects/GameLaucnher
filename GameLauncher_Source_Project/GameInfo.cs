using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher
{
    public class GameInfo
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string ExePath { get; set; }
        public double PlayTime { get; set; }  // в часах
        public DateTime LastPlayed { get; set; }
    }
}
