namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_item_entity_hasbeen_updated : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Items", "Category1");
            DropColumn("dbo.Items", "Category2");
            DropColumn("dbo.Items", "Category3");
            DropColumn("dbo.Items", "Category4");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Category4", c => c.String());
            AddColumn("dbo.Items", "Category3", c => c.String());
            AddColumn("dbo.Items", "Category2", c => c.String());
            AddColumn("dbo.Items", "Category1", c => c.String());
        }
    }
}
