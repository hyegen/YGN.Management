using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGN.DataAccesLayer.Concrete;

namespace YGN.BusinessLayer.ConfigManager
{
    public class CreateDatabaseManager
    {
        public static bool CreateDatabase()
        {
            try
            {
                var createDatabaseResult = ConfigDal.Create();
                if (createDatabaseResult)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }

        }
    }
}
