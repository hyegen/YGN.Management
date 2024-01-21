namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_clientTransaction_added1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClientTransactions", "ProcessDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClientTransactions", "ProcessDate", c => c.Int(nullable: false));
        }
    }
}
