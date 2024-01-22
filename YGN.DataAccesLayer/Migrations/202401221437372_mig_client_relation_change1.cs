namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_client_relation_change1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClientTransactions", "Id", "dbo.Clients");
            DropIndex("dbo.ClientTransactions", new[] { "Id" });
            AlterColumn("dbo.ClientTransactions", "Id", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.ClientTransactions", "ClientId");
            AddForeignKey("dbo.ClientTransactions", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientTransactions", "ClientId", "dbo.Clients");
            DropIndex("dbo.ClientTransactions", new[] { "ClientId" });
            AlterColumn("dbo.ClientTransactions", "Id", c => c.Int(nullable: false));
            CreateIndex("dbo.ClientTransactions", "Id");
            AddForeignKey("dbo.ClientTransactions", "Id", "dbo.Clients", "Id");
        }
    }
}
