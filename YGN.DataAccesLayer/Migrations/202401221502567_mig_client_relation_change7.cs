namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_client_relation_change7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Address", c => c.String(maxLength: 30));
            DropColumn("dbo.Clients", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Email", c => c.String(maxLength: 30));
            DropColumn("dbo.Clients", "Address");
        }
    }
}
