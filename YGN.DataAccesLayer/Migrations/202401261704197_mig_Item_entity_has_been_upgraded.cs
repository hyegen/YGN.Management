namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_Item_entity_has_been_upgraded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "ItemCode", c => c.String(maxLength: 40));
            AlterColumn("dbo.Items", "ItemName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Items", "Brand", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Brand", c => c.String());
            AlterColumn("dbo.Items", "ItemName", c => c.String());
            AlterColumn("dbo.Items", "ItemCode", c => c.String());
        }
    }
}
