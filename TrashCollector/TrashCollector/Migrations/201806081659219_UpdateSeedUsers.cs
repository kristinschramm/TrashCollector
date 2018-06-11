namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'030dd852-c148-4f8c-be16-8dfe9392b086', N'admin@trash.com', 0, N'AGGwuSoNkADqO0wLQ/Q7JY1+6og9VTDCpR6bZDR92oSqG6Cu9/GgcxoaUT/3WgPBEA==', N'771c51b8-1258-4d16-af6d-d65a3be8e458', NULL, 0, 0, NULL, 1, 0, N'admin@trash.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'13447433-eea9-43eb-a56d-6d0635c4a69c', N'customer@trash.com', 0, N'AKfO/oKP15CLW1uZJvAbaStF+1Z0j6+OZaJ6Qd7S5yTvmzEGV+vzRrcuzUVWxYFFlg==', N'5016b213-6e11-43bb-b056-c49cc18802a5', NULL, 0, 0, NULL, 1, 0, N'customer@trash.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9cb8dcca-c415-4550-a316-9876f10112eb', N'employee@trash.com', 0, N'AANCmZqX1thIXLfwHRuK9cOGtVpm5tRkOdfz4BDGP7Rh323EE5hxMkQTKr0QDxSyIg==', N'28cf1366-61fb-4e49-84c5-bb5bef3bfe1c', NULL, 0, 0, NULL, 1, 0, N'employee@trash.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1', N'admin')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2', N'employee')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3', N'customer')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'030dd852-c148-4f8c-be16-8dfe9392b086', N'1')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9cb8dcca-c415-4550-a316-9876f10112eb', N'2')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'13447433-eea9-43eb-a56d-6d0635c4a69c', N'3')


");
        }
        
        public override void Down()
        {
        }
    }
}
