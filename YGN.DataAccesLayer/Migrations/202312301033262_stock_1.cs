namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stock_1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StockTransactions", "ProcessDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StockTransactions", "ProcessDate", c => c.DateTime(nullable: false));
        }
    }
}
