namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderFiches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        ProcessDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        OrderFicheId = c.Int(nullable: false),
                        ProcessDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderFiches", t => t.OrderFicheId, cascadeDelete: true)
                .Index(t => t.OrderFicheId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLines", "OrderFicheId", "dbo.OrderFiches");
            DropIndex("dbo.OrderLines", new[] { "OrderFicheId" });
            DropTable("dbo.OrderLines");
            DropTable("dbo.OrderFiches");
        }
    }
}
