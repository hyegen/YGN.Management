namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_relationship_between_orderline_and_orderfiche_last1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderLines", "OrderFicheId", c => c.Int(nullable: false));
            CreateIndex("dbo.OrderLines", "OrderFicheId");
            AddForeignKey("dbo.OrderLines", "OrderFicheId", "dbo.OrderFiches", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLines", "OrderFicheId", "dbo.OrderFiches");
            DropIndex("dbo.OrderLines", new[] { "OrderFicheId" });
            DropColumn("dbo.OrderLines", "OrderFicheId");
        }
    }
}
