namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itementitychanged : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Items", "ItemStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "ItemStatus", c => c.Boolean(nullable: false));
        }
    }
}
