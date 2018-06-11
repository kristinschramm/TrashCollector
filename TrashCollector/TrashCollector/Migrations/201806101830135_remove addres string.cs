namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeaddresstring : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "AddressString");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "AddressString", c => c.String());
        }
    }
}
