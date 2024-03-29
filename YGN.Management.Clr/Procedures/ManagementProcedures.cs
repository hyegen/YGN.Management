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
    [SqlProcedure(Name = "YGN_DELETE_CLIENT_BY_ID")]
    public static void YGN_DELETE_CLIENT_BY_ID(SqlInt32 ID)
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                  DELETE FROM Clients WHERE Id=@ID
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

    [SqlProcedure(Name = "YGN_GET_ALL_ITEM")]
    public static void YGN_GET_ITEM()
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                SELECT * FROM Items WITH(NOLOCK)
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
    [SqlProcedure(Name = "YGN_DELETE_ITEM_BY_ID")]
    public static void YGN_DELETE_ITEM_BY_ID(SqlInt32 ID)
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                  DELETE FROM Items WHERE Id=@ID
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

    #region ORDER PROCEDURES
    [SqlProcedure(Name = "YGN_ORDERLINE_VIEW")]
    public static void YGN_ORDERLINE_VIEW()
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
 
             SELECT ITM.ItemCode,ITM.ItemName,ITM.UnitPrice,ORL.Amount FROM OrderLines ORL 
	            LEFT JOIN Items ITM ON ITM.Id=ORL.ItemId
	            GROUP BY ITM.ItemCode,ITM.ItemName,ITM.UnitPrice,ORL.Amount
                ");
            var sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            sqlConn.Open();
            if (SqlContext.Pipe != null)
                SqlContext.Pipe.Send(sqlCmd.ExecuteReader());
            sqlConn.Close();
        }

    }

    #endregion

    #region ORDER FICHE MAKER PROCEDURE

    [SqlProcedure(Name = "YGN_CREATE_FICHENO")]
    public static void YGN_CREATE_FICHENO()
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                   
                    DECLARE @LASTFICHENO INT 

                    SELECT TOP 1 @LASTFICHENO=FicheNo  FROM OrderFiches  ORDER BY ProcessDate DESC

	                SET @LASTFICHENO=@LASTFICHENO+1
	                SELECT @LASTFICHENO [LAST FICHENO]
               
                ");
            var sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            sqlConn.Open();
            if (SqlContext.Pipe != null)
                SqlContext.Pipe.Send(sqlCmd.ExecuteReader());
            sqlConn.Close();
        }
    }
    [SqlProcedure(Name = "YGN_ORDER_FICHE_MAKER")]
    public static void YGN_ORDER_FICHE_MAKER()
    {
        using (var sqlConn = new SqlConnection("context connection=true"))
        {
            var sqlSelect = string.Format(@"
                
             SELECT cl.ClientName,ClientSurname,cl.FirmDescription,itm.ItemCode,itm.ItemName,itm.UnitPrice,orl.ProcessDate FROM  OrderFiches orf
	            inner join Clients cl on cl.Id= orf.ClientId
	            inner join OrderLines orl on orl.OrderFicheId= orf.Id
	            left join Items itm on itm.Id= orl.ItemId
	            group by itm.ItemCode,itm.ItemName,itm.UnitPrice,cl.ClientName,ClientSurname,cl.FirmDescription,orl.ProcessDate

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