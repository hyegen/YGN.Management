using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class ManagementProcedures
{
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
               
               SELECT TOP 1 @LASTINDEX=ClientId FROM ClientTransactions WITH(NOLOCK)  ORDER BY Id DESC
                   SET @LASTINDEX= @LASTINDEX+1 
               
               IF @LASTINDEX IS NULL
               BEGIN
	               SET @LASTSTRINGVALUE= 1
               END
               
               ELSE 
               BEGIN 
               SET @STRINGVALUE=(SELECT  TOP 1 SUBSTRING(ClientCode, 1, PATINDEX('%[0-9]%', ClientCode) - 1) 
               FROM Clients CLNT WITH(NOLOCK)
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

    [SqlProcedure(Name = "YGN_GET_ALL_CLIENT")]
    public static void YGN_GET_ALL_CLIENT()
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                SELECT * FROM Clients WITH(NOLOCK)
                ");
            var sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            sqlConn.Open();
            if (SqlContext.Pipe != null)
                SqlContext.Pipe.Send(sqlCmd.ExecuteReader());
            sqlConn.Close();
        }
    }

    #endregion

    #region Item Procedures

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

    [SqlProcedure(Name = "YGN_ITEMCODECREATOR")]
    public static void YGN_ITEMCODECREATOR()
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                
                DECLARE @STRINGVALUE NVARCHAR(50)
                DECLARE @LASTINDEX INT 
                DECLARE @LASTSTRINGVALUE NVARCHAR(50)
                               
                SELECT TOP 1 @LASTINDEX=ItemId FROM StockTransactions WITH(NOLOCK)  ORDER BY Id DESC
                    SET @LASTINDEX= @LASTINDEX+1 
                               
                IF @LASTINDEX IS NULL
                BEGIN
                	SET @LASTSTRINGVALUE= 1
                END
                               
                ELSE 
                BEGIN 
                SET @STRINGVALUE=(SELECT  TOP 1 SUBSTRING(ItemCode, 1, PATINDEX('%[0-9]%', ItemCode) - 1) 
                FROM Items ITM WITH(NOLOCK)
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

    [SqlProcedure(Name = "YGN_GET_ITEM_BY_ID")]
    public static void YGN_GET_ITEM_BY_ID(SqlInt32 ID)
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                   SELECT * FROM Items WITH(NOLOCK) WHERE Id=@ID
                ");
            var sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            sqlCmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int) { Value = ID });

            sqlConn.Open();
            if (SqlContext.Pipe != null)
                SqlContext.Pipe.Send(sqlCmd.ExecuteReader());
            sqlConn.Close();
        }
    }

    [SqlProcedure(Name = "YGN_GET_ITEM_FOR_FILLING_PURCHASE_ITEMS_GRID")]
    public static void YGN_GET_ITEM_FOR_FILLING_PURCHASE_ITEMS_GRID()
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                SELECT ItemCode,ItemName,UnitPrice FROM  Items WITH(NOLOCK)  
                ");
            var sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            sqlConn.Open();
            if (SqlContext.Pipe != null)
                SqlContext.Pipe.Send(sqlCmd.ExecuteReader());
            sqlConn.Close();
        }

    }
    #endregion

    #region ORDER PROCEDURES
    [SqlProcedure(Name = "YGN_ORDERLINE_VIEW")]
    public static void YGN_ORDERLINE_VIEW()
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                
                SELECT itm.ItemCode,itm.ItemName,orl.Amount FROM OrderLines orl WITH(NOLOCK)
	                inner join OrderFiches orf on orf.Id=orl.OrderFicheId
	                inner join Items itm on itm.Id= orl.ItemId
	                inner join Clients cl on cl.Id=orl.ClientId
	                inner join Users us on us.Id=orl.UserId
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