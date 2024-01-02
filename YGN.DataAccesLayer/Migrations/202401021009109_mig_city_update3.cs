namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_city_update3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cities", "Description", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cities", "Description", c => c.String(nullable: false));
        }
    }
}
