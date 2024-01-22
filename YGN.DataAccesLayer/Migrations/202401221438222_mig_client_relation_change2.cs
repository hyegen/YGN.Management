namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_client_relation_change2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClientTransactions", "ClientId", "dbo.Clients");
            DropIndex("dbo.ClientTransactions", new[] { "ClientId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.ClientTransactions", "ClientId");
            AddForeignKey("dbo.ClientTransactions", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
        }
    }
}
