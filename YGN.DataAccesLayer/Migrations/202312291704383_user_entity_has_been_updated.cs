namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_entity_has_been_updated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "BirthDate", c => c.DateTime());
            AlterColumn("dbo.Users", "CreatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}
