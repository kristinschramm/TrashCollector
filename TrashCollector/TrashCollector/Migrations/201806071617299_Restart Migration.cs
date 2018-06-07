namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestartMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "StateId", "dbo.States");
            DropForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Addresses", new[] { "StateId" });
            DropIndex("dbo.Customers", new[] { "Address_Id" });
            CreateTable(
                "dbo.ZipCodes",
                c => new
                    {
                        ZipCodeId = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ZipCodeId);
            
            AddColumn("dbo.Customers", "Address", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "ZipCodeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "ZipCodeId");
            AddForeignKey("dbo.Customers", "ZipCodeId", "dbo.ZipCodes", "ZipCodeId", cascadeDelete: true);
            DropColumn("dbo.Customers", "Address_Id");
            DropTable("dbo.Addresses");
            DropTable("dbo.States");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                        PostalCode = c.String(maxLength: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StreetAddress = c.String(),
                        SubAddress = c.String(),
                        City = c.String(),
                        ZipCode = c.String(maxLength: 5),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "Address_Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.Customers", "ZipCodeId", "dbo.ZipCodes");
            DropIndex("dbo.Customers", new[] { "ZipCodeId" });
            DropColumn("dbo.Customers", "ZipCodeId");
            DropColumn("dbo.Customers", "Address");
            DropTable("dbo.ZipCodes");
            CreateIndex("dbo.Customers", "Address_Id");
            CreateIndex("dbo.Addresses", "StateId");
            AddForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Addresses", "StateId", "dbo.States", "Id", cascadeDelete: true);
        }
    }
}
