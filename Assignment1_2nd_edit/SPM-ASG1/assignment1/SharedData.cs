using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class SharedData
    {
        public static string Data { get; set; }
        public static bool t { get; set; }
        public static string building { get; set; }

        public static string Column { get; set; }
        public static string Row { get; set; }
        public static int turn { get; set; }
        public static int coins { get; set; }
        public static int point { get; set; }

        public static string Version { get; set; }
        public static int x { get; set; }
        public static int y { get; set; }
    }
}
