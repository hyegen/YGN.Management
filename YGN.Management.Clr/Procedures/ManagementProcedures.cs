using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class ManagementProcedures
{
    [SqlProcedure(Name ="TestProcedure")]
    public static void TestProcedure()
    {
        SqlPipe sqlPipe = SqlContext.Pipe;
        sqlPipe.Send("First Procedure of my own project.");
    }
}
