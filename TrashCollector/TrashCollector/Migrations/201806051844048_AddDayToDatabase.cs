namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDayToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Days",
                c => new
                    {
                        DayId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DayId);
            
            AddColumn("dbo.Customers", "DayId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "DayId");
            AddForeignKey("dbo.Customers", "DayId", "dbo.Days", "DayId", cascadeDelete: true);
            Sql("INSERT INTO DAYS VALUES ('Monday')");
            Sql("INSERT INTO DAYS VALUES ('Tuesday')");
            Sql("INSERT INTO DAYS VALUES ('Wednesday')");
            Sql("INSERT INTO DAYS VALUES ('Thursday')");
            Sql("INSERT INTO DAYS VALUES ('Friday')");

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "DayId", "dbo.Days");
            DropIndex("dbo.Customers", new[] { "DayId" });
            DropColumn("dbo.Customers", "DayId");
            DropTable("dbo.Days");
        }
    }
}
