using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Enums
{
    public class GlobalVariables
    {
        public const int USERID = 1;
        public static ConnectionInfo ConnectionInfo { get; set; }
        public static string AppPath { get; set; }
    }
}
