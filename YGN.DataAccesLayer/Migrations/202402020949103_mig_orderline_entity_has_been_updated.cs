namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_orderline_entity_has_been_updated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderLines", "OrderFicheId", "dbo.OrderFiches");
            DropIndex("dbo.OrderLines", new[] { "OrderFicheId" });
            RenameColumn(table: "dbo.OrderLines", name: "OrderFicheId", newName: "OrderFiche_Id");
            AddColumn("dbo.OrderLines", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.OrderLines", "ClientId", c => c.Int(nullable: false));
            AddColumn("dbo.OrderLines", "TotalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.OrderLines", "Amount", c => c.Double(nullable: false));
            AlterColumn("dbo.OrderLines", "OrderFiche_Id", c => c.Int());
            CreateIndex("dbo.OrderLines", "OrderFiche_Id");
            AddForeignKey("dbo.OrderLines", "OrderFiche_Id", "dbo.OrderFiches", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLines", "OrderFiche_Id", "dbo.OrderFiches");
            DropIndex("dbo.OrderLines", new[] { "OrderFiche_Id" });
            AlterColumn("dbo.OrderLines", "OrderFiche_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderLines", "Amount", c => c.Int(nullable: false));
            DropColumn("dbo.OrderLines", "TotalPrice");
            DropColumn("dbo.OrderLines", "ClientId");
            DropColumn("dbo.OrderLines", "UserId");
            RenameColumn(table: "dbo.OrderLines", name: "OrderFiche_Id", newName: "OrderFicheId");
            CreateIndex("dbo.OrderLines", "OrderFicheId");
            AddForeignKey("dbo.OrderLines", "OrderFicheId", "dbo.OrderFiches", "Id", cascadeDelete: true);
        }
    }
}
