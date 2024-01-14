namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clien_entity_has_been_updated_using_fluent_validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "ClientName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Clients", "ClientSurname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Clients", "Email", c => c.String(maxLength: 30));
            AlterColumn("dbo.Clients", "TelNr1", c => c.String(maxLength: 11));
            AlterColumn("dbo.Clients", "TelNr2", c => c.String(maxLength: 11));
            AlterColumn("dbo.Clients", "FirmDescription", c => c.String(maxLength: 150));
            AlterColumn("dbo.Clients", "TaxIdentificationNumber", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "TaxIdentificationNumber", c => c.String());
            AlterColumn("dbo.Clients", "FirmDescription", c => c.String());
            AlterColumn("dbo.Clients", "TelNr2", c => c.String());
            AlterColumn("dbo.Clients", "TelNr1", c => c.String());
            AlterColumn("dbo.Clients", "Email", c => c.String());
            AlterColumn("dbo.Clients", "ClientSurname", c => c.String());
            AlterColumn("dbo.Clients", "ClientName", c => c.String(nullable: false));
        }
    }
}
