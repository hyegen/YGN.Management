namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_fiche_no_colum_added_to_orderfiche_entity3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderFiches", "FicheNo", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderFiches", "FicheNo", c => c.String());
        }
    }
}
