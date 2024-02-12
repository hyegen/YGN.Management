namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig32 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Amount", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Amount", c => c.Int(nullable: false));
        }
    }
}
