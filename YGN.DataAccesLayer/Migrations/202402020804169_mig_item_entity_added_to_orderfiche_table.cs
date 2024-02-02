namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_item_entity_added_to_orderfiche_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "OrderFiche_Id", c => c.Int());
            CreateIndex("dbo.Items", "OrderFiche_Id");
            AddForeignKey("dbo.Items", "OrderFiche_Id", "dbo.OrderFiches", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "OrderFiche_Id", "dbo.OrderFiches");
            DropIndex("dbo.Items", new[] { "OrderFiche_Id" });
            DropColumn("dbo.Items", "OrderFiche_Id");
        }
    }
}
