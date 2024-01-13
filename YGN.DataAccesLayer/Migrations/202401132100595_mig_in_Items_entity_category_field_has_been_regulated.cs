namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_in_Items_entity_category_field_has_been_regulated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Category1", c => c.String());
            AddColumn("dbo.Items", "Category2", c => c.String());
            AddColumn("dbo.Items", "Category3", c => c.String());
            AddColumn("dbo.Items", "Category4", c => c.String());
            DropColumn("dbo.Items", "Categorty1");
            DropColumn("dbo.Items", "Categorty2");
            DropColumn("dbo.Items", "Categorty3");
            DropColumn("dbo.Items", "Categorty4");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Categorty4", c => c.String());
            AddColumn("dbo.Items", "Categorty3", c => c.String());
            AddColumn("dbo.Items", "Categorty2", c => c.String());
            AddColumn("dbo.Items", "Categorty1", c => c.String());
            DropColumn("dbo.Items", "Category4");
            DropColumn("dbo.Items", "Category3");
            DropColumn("dbo.Items", "Category2");
            DropColumn("dbo.Items", "Category1");
        }
    }
}
