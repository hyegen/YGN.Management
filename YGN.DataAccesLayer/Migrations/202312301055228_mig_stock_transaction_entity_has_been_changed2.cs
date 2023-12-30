namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_stock_transaction_entity_has_been_changed2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "AddressText", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "AddressText", c => c.String(nullable: false));
        }
    }
}
