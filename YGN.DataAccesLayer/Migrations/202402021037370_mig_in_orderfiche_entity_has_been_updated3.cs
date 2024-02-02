namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_in_orderfiche_entity_has_been_updated3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.OrderFiches", "Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderFiches", "Amount", c => c.Double(nullable: false));
        }
    }
}
