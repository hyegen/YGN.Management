namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_deleted_item_in_orderfiche_entity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderFiches", "ItemId", "dbo.Items");
            DropIndex("dbo.OrderFiches", new[] { "ItemId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.OrderFiches", "ItemId");
            AddForeignKey("dbo.OrderFiches", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
        }
    }
}
