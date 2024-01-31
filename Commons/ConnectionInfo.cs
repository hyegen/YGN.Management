using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class ConnectionInfo
    {
        public string ServerName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DatabaseName { get; set; }
        public  string ConnectionString { get { return string.Format(GlobalConsts.CONNECTION_STRING_TEMPLATE, ServerName, UserName, Password, DatabaseName); } }
        public string ToString() { return string.Format(GlobalConsts.CONNECTION_INFO_TEMPLATE, ServerName, UserName, Password, DatabaseName); }
    }
}
