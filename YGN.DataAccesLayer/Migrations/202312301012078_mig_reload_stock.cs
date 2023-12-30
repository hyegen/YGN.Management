namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_reload_stock : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ProcessDate = c.DateTime(nullable: false),
                        TrCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StockTransactions");
        }
    }
}
