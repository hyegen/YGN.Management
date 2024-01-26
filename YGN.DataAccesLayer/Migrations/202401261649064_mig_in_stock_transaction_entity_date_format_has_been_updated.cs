namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_in_stock_transaction_entity_date_format_has_been_updated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StockTransactions", "ProcessDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StockTransactions", "ProcessDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
