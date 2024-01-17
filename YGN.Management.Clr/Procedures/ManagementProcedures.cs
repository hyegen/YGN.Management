using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class ManagementProcedures
{
    [SqlProcedure(Name = "YGN_GET_ALL_ITEM")]
    public static void YGN_GET_ITEM()
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                SELECT * FROM Items
                ");
            var sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            sqlConn.Open();
            if (SqlContext.Pipe != null)
                SqlContext.Pipe.Send(sqlCmd.ExecuteReader());
            sqlConn.Close();
        }
    }
    [SqlProcedure(Name = "YGN_GET_ALL_CLIENT")]
    public static void YGN_GET_ALL_CLIENT()
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                SELECT * FROM Clients
                ");
            var sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            sqlConn.Open();
            if (SqlContext.Pipe != null)
                SqlContext.Pipe.Send(sqlCmd.ExecuteReader());
            sqlConn.Close();
        }
    }
}
