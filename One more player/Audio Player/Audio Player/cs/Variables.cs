using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_Player
{
    public static class Variables
    {
        public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;
        public static List<string> Files = new List<string>();
        public static int CurrentTrackNumber;
        public static string GetFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }
    }
}
