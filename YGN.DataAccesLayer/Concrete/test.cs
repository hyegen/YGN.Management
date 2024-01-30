
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGN.DataAccesLayer.Concrete
{
    public class test
    {
        //public static bool TryConnection(string pConnectionString = null)
        //{
        //    try
        //    {
        //        using (YGNContext context = new YGNContext())
        //        {
        //            if (context.Database.Connection.State == System.Data.ConnectionState.Closed)
        //            {
        //                context.Database.Connection.Open();
        //                context.Database.Connection.Close();
        //                return true;
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    return false;
        //}
        public static bool TryConnection(string pConnectionString = null)
        {
            try
            {
                using (YGNContext context = new YGNContext())
                {
                    if (context.Database.Connection.State == System.Data.ConnectionState.Closed)
                    {
                        context.Database.Connection.Open();
                        context.Database.Connection.Close();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
    }
}
