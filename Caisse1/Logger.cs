using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caisse1
{
    public static class CaisseLogger
    {
        public static System.IO.StreamWriter fileError = new System.IO.StreamWriter("C:\\Users\\SERIALIZABLE\\Documents\\Visual Studio 2017\\Projects\\Caisse1\\LogError.txt", true);
        public static System.IO.StreamWriter fileInfo = new System.IO.StreamWriter("C:\\Users\\SERIALIZABLE\\Documents\\Visual Studio 2017\\Projects\\Caisse1\\LogInfo.txt", true);
        public static void LogError(String lines)
        {
            DateTime now = DateTime.Now;
            fileError.WriteLine(now + " : " + lines);
        }
        public static void LogInfo(String lines)
        {
            DateTime now = DateTime.Now;
            fileInfo.WriteLine(now + " : " + lines);
        }
    }
    
}
