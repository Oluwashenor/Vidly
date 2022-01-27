namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'27f951c0-d719-460f-b330-cb900fcee874', N'admin@vidly.com', 0, N'AE3bra+29PAHEYWZDRIPZZpN+L5mUR/b4zjyDqaqRHbTGrifuo3Rx6ryOIetJrILJw==', N'e8c51773-469a-4608-aab2-3e5cfa81d902', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd41c1dfd-15f4-4f86-8eea-260491e727a7', N'guest@vidly.com', 0, N'APmN9nEkVZ//IXkLWevyniOvmk/d5Tt00PIO7JDhAg0Fy5IRQQ3T7lT9otm58LjY+w==', N'48007228-6112-4d4f-8946-210a6406add1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5cf966b3-6acb-4ea9-9d6e-7ce7ab19a184', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'27f951c0-d719-460f-b330-cb900fcee874',N'5cf966b3-6acb-4ea9-9d6e-7ce7ab19a184')

");
        }
        
        public override void Down()
        {
        }
    }
}
