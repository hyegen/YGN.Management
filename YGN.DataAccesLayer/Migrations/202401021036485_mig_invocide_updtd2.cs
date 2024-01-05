namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_invocide_updtd2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Invoices", "CargoFicheNo", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Invoices", "CargoFicheNo", c => c.String());
        }
    }
}