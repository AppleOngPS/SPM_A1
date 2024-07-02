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
        // for building
        public static string PreviousOption {  get; set; }
        public static string CurrentOption { get; set; }
        // for row
        public static string TempRow { get; set; }
        //for Column
        public static string TempColumn { get; set; }
        public static bool flag { get; set; }
        public static string Column { get; set; }
        public static string Row { get; set; }
        public static int turn { get; set; }
        public static int coins { get; set; } = 16;
        public static int point { get; set; } = 0;
        public static int rows { get; set; }
        public static string Dx { get; set; }
        public static string Dy { get; set; }
        public static string Version { get; set; }
        public static int x { get; set; }
        public static int y { get; set; }

        public static bool TFlag { get; set; }

        public static bool TFlag2 { get; set; }
        public static bool TFlag3 { get; set; }
    }
}
