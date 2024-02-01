namespace YGN.DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        TownId = c.Int(nullable: false),
                        DistrictId = c.Int(nullable: false),
                        PostalCode = c.String(),
                        AddressText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryId = c.Int(nullable: false),
                        Description = c.String(maxLength: 50),
                        District = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClientTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        ProcessDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TownId = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoiceId = c.Int(nullable: false),
                        OrderDetailId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LineTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ProcessDate = c.DateTime(nullable: false),
                        AddressId = c.Int(nullable: false),
                        CargoFicheNo = c.String(maxLength: 50),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.YGN_CTGRYOFITMS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemCode = c.String(maxLength: 40),
                        ItemName = c.String(maxLength: 50),
                        UnitPrice = c.Double(),
                        Brand = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LineTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProcessDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        PaymentType = c.Int(nullable: false),
                        ProcessDate = c.DateTime(nullable: false),
                        IsOk = c.Boolean(nullable: false),
                        ApproveCode = c.String(),
                        PaymentTotal = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StockTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemId = c.Int(nullable: false),
                        OrderId = c.Int(),
                        UserId = c.Int(nullable: false),
                        ProcessDate = c.DateTime(nullable: false),
                        TrCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Towns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityId = c.Int(nullable: false),
                        Description = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        NameSurname = c.String(),
                        Email = c.String(),
                        Gender = c.String(),
                        BirthDate = c.DateTime(storeType: "date"),
                        CreatedDate = c.DateTime(storeType: "date"),
                        TelNr1 = c.String(),
                        TelNr2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientCode = c.String(maxLength: 40),
                        ClientName = c.String(nullable: false, maxLength: 50),
                        ClientSurname = c.String(maxLength: 50),
                        Address = c.String(maxLength: 30),
                        TelNr1 = c.String(maxLength: 11),
                        TelNr2 = c.String(maxLength: 11),
                        FirmDescription = c.String(maxLength: 150),
                        TaxIdentificationNumber = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
            DropTable("dbo.Users");
            DropTable("dbo.Towns");
            DropTable("dbo.StockTransactions");
            DropTable("dbo.Payments");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Items");
            DropTable("dbo.YGN_CTGRYOFITMS");
            DropTable("dbo.Invoices");
            DropTable("dbo.InvoiceDetails");
            DropTable("dbo.Districts");
            DropTable("dbo.Countries");
            DropTable("dbo.ClientTransactions");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}
