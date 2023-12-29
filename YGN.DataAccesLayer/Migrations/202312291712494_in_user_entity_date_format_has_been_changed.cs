namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class in_user_entity_date_format_has_been_changed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "BirthDate", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "BirthDate", c => c.DateTime());
        }
    }
}
