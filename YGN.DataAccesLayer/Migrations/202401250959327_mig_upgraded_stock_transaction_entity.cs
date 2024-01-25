namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_upgraded_stock_transaction_entity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StockTransactions", "OrderId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StockTransactions", "OrderId", c => c.Int(nullable: false));
        }
    }
}
