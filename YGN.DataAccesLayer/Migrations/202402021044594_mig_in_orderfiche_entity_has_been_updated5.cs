namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_in_orderfiche_entity_has_been_updated5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.OrderFiches", "ItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderFiches", "ItemId", c => c.Int(nullable: false));
        }
    }
}
