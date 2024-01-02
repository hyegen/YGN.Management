namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_city_chngs5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cities", "Description", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cities", "Description", c => c.String());
        }
    }
}
