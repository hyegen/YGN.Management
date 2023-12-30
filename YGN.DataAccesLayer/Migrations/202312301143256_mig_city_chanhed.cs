namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_city_chanhed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cities", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Cities", "District", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cities", "District", c => c.Int(nullable: false));
            AlterColumn("dbo.Cities", "Description", c => c.Int(nullable: false));
        }
    }
}
