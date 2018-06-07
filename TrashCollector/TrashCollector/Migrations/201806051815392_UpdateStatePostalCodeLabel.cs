namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStatePostalCodeLabel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.States", "PostalCode", c => c.String(maxLength: 2));
            DropColumn("dbo.States", "StateAbrev");
        }
        
        public override void Down()
        {
            AddColumn("dbo.States", "StateAbrev", c => c.String(maxLength: 2));
            DropColumn("dbo.States", "PostalCode");
        }
    }
}
