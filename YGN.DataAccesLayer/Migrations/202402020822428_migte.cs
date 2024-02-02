namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migte : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "OrderFiche_Id", "dbo.OrderFiches");
            DropIndex("dbo.Items", new[] { "OrderFiche_Id" });
            CreateIndex("dbo.OrderFiches", "ItemId");
            AddForeignKey("dbo.OrderFiches", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
            DropColumn("dbo.Items", "OrderFiche_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "OrderFiche_Id", c => c.Int());
            DropForeignKey("dbo.OrderFiches", "ItemId", "dbo.Items");
            DropIndex("dbo.OrderFiches", new[] { "ItemId" });
            CreateIndex("dbo.Items", "OrderFiche_Id");
            AddForeignKey("dbo.Items", "OrderFiche_Id", "dbo.OrderFiches", "Id");
        }
    }
}
