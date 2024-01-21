namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_clientTransaction_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        ProcessDate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientTransactions", "ClientId", "dbo.Clients");
            DropIndex("dbo.ClientTransactions", new[] { "ClientId" });
            DropTable("dbo.ClientTransactions");
        }
    }
}
