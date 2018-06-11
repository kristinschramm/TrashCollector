namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addaccountbalancetocustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "AccountBalance", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "AccountBalance");
        }
    }
}
