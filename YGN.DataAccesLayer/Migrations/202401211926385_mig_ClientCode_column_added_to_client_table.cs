namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_ClientCode_column_added_to_client_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "ClientCode", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "ClientCode");
        }
    }
}
