using Commons.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YGN.DataAccesLayer.Concrete
{
    public class SqlData
    {
        public static bool ExecuteQuery(string commandText, string connectionString = null)
        {
            try
            {
                ExecuteNonQuery(commandText, connectionString);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static void ExecuteNonQuery(string commandText, string connectionString = null)
        {
            using (var cnn = new SqlConnection(connectionString ?? GlobalVariables.ConnectionInfo.ConnectionString))
            {
                var regex = new Regex("^GO", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                var queries = regex.Split(commandText);
                cnn.Open();
                foreach (var cmdText in queries)
                {
                    if (!string.IsNullOrEmpty(cmdText.Trim()))
                    {
                        using (var cmd = new SqlCommand(cmdText.Trim(), cnn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                cnn.Close();
            }
        }
    }
}
