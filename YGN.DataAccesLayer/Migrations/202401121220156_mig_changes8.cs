namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_changes8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "UnitPrice", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "UnitPrice", c => c.Single(nullable: false));
        }
    }
}
