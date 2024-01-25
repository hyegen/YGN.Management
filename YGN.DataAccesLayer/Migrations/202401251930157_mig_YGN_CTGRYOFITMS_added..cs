namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_YGN_CTGRYOFITMS_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.YGN_CTGRYOFITMS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.YGN_CTGRYOFITMS");
        }
    }
}
