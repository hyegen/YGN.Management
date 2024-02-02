namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig70 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "UnitPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "UnitPrice", c => c.Double());
        }
    }
}
