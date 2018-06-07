namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateemployeecolumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "ZipCodeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "ZipCodeId");
            AddForeignKey("dbo.Employees", "ZipCodeId", "dbo.ZipCodes", "ZipCodeId", cascadeDelete: true);
            DropColumn("dbo.Employees", "ZipCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "ZipCode", c => c.Int(nullable: false));
            DropForeignKey("dbo.Employees", "ZipCodeId", "dbo.ZipCodes");
            DropIndex("dbo.Employees", new[] { "ZipCodeId" });
            DropColumn("dbo.Employees", "ZipCodeId");
        }
    }
}
