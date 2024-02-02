namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_orderline_entity_has_been_updated1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderLines", "OrderFiche_Id", "dbo.OrderFiches");
            DropIndex("dbo.OrderLines", new[] { "OrderFiche_Id" });
            DropColumn("dbo.OrderLines", "OrderFiche_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderLines", "OrderFiche_Id", c => c.Int());
            CreateIndex("dbo.OrderLines", "OrderFiche_Id");
            AddForeignKey("dbo.OrderLines", "OrderFiche_Id", "dbo.OrderFiches", "Id");
        }
    }
}
