namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_fiche_no_colum_added_to_orderfiche_entity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderFiches", "FicheNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderFiches", "FicheNo");
        }
    }
}
