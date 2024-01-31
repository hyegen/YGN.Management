using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class ManagementProcedures
{
    #region General Get Procedures

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

    #endregion

    #region Client Procedures
    [SqlProcedure(Name = "YGN_CLIENTCODECREATOR")]
    public static void YGN_CLIENTCODECREATOR()
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                
               DECLARE @STRINGVALUE NVARCHAR(50)
               DECLARE @LASTINDEX INT 
               DECLARE @LASTSTRINGVALUE NVARCHAR(50)
               
               SELECT TOP 1 @LASTINDEX=ClientId FROM ClientTransactions  ORDER BY Id DESC
                   SET @LASTINDEX= @LASTINDEX+1 
               
               IF @LASTINDEX IS NULL
               BEGIN
	               SET @LASTSTRINGVALUE= 1
               END
               
               ELSE 
               BEGIN 
               SET @STRINGVALUE=(SELECT  TOP 1 SUBSTRING(ClientCode, 1, PATINDEX('%[0-9]%', ClientCode) - 1) 
               FROM Clients CLNT 
                   LEFT JOIN ClientTransactions CLTRNS ON CLTRNS.ClientId=CLNT.Id
               WHERE PATINDEX('%[0-9]%', ClientCode) > 0 
               ORDER BY ClientCode DESC) + CONVERT(nvarchar(50),@LASTINDEX)
               
               SET @LASTSTRINGVALUE=@STRINGVALUE
               
               SELECT @LASTSTRINGVALUE AS [RESULT]
               END
                ");
            var sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            sqlConn.Open();
            if (SqlContext.Pipe != null)
                SqlContext.Pipe.Send(sqlCmd.ExecuteReader());
            sqlConn.Close();
        }

    }

    [SqlProcedure(Name = "YGN_GET_CATEGORIES")]
    public static void YGN_GET_CATEGORIES()
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                   SELECT Category1 FROM Items WITH(NOLOCK)
                ");
            var sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            sqlConn.Open();
            if (SqlContext.Pipe != null)
                SqlContext.Pipe.Send(sqlCmd.ExecuteReader());
            sqlConn.Close();
        }
    }

    [SqlProcedure(Name = "YGN_GET_CLIENT_BY_ID")]
    public static void YGN_GET_CLIENT_BY_ID(SqlInt32 ID)
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                   SELECT * FROM Clients WITH(NOLOCK) WHERE Id=@ID
                ");
            var sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            sqlCmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = ID });

            sqlConn.Open();
            if (SqlContext.Pipe != null)
                SqlContext.Pipe.Send(sqlCmd.ExecuteReader());
            sqlConn.Close();
        }
    }

    #endregion


    #region Item Procedures

    [SqlProcedure(Name = "YGN_ITEMCODECREATOR")]
    public static void YGN_ITEMCODECREATOR()
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                
                DECLARE @STRINGVALUE NVARCHAR(50)
                DECLARE @LASTINDEX INT 
                DECLARE @LASTSTRINGVALUE NVARCHAR(50)
                               
                SELECT TOP 1 @LASTINDEX=ItemId FROM StockTransactions  ORDER BY Id DESC
                    SET @LASTINDEX= @LASTINDEX+1 
                               
                IF @LASTINDEX IS NULL
                BEGIN
                	SET @LASTSTRINGVALUE= 1
                END
                               
                ELSE 
                BEGIN 
                SET @STRINGVALUE=(SELECT  TOP 1 SUBSTRING(ItemCode, 1, PATINDEX('%[0-9]%', ItemCode) - 1) 
                FROM Items ITM 
                    LEFT JOIN StockTransactions STTRNS ON STTRNS.ItemId=ITM.Id
                WHERE PATINDEX('%[0-9]%', ItemCode) > 0 
                ORDER BY ItemCode DESC) + CONVERT(nvarchar(50),@LASTINDEX)
                               
                SET @LASTSTRINGVALUE=@STRINGVALUE
                               
                SELECT @LASTSTRINGVALUE AS [RESULT]
                END

                ");
            var sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            sqlConn.Open();
            if (SqlContext.Pipe != null)
                SqlContext.Pipe.Send(sqlCmd.ExecuteReader());
            sqlConn.Close();
        }

    }
    #endregion
}