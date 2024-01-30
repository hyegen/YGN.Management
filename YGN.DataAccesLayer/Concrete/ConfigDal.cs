using Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.DataAccesLayer.Properties;

namespace YGN.DataAccesLayer.Concrete
{
    public class ConfigDal
    {
        public static bool Create()
        {
            using (YGNContext context= new YGNContext())
            {
                context.Database.CreateIfNotExists();
                return true;
            }
          
            //  return SqlData.ExecuteQuery(string.Format(Resources.CreateTables, GlobalVariables.ConnectionInfo.DatabaseName), GlobalVariables.ConnectionInfo.ConnectionString);
        }
    }
}
