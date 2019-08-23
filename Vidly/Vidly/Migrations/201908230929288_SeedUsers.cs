namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'20cf8ca1-eb52-40fb-8351-bc524235698d', N'admin@gmail.com', 0, N'AA+Yx83Z3NfmCrptN1rFgu8HSuqWP0Zf6KSPPSOZHu9fiSyJyIdPtpF+CqXyYSalkA==', N'934703ab-ed8a-45f1-ab4b-c9138ea006d0', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'213f6921-1c79-4f23-b427-e9b38639ca16', N'mirakuru@gmail.com', 0, N'AIBl3ARqSftw0DEFdpeoQFmXw0hfMiboDTfyxCHDl+3qy+lrjwRP46xWx4SDUwUIbw==', N'1cc2b771-0bba-4d1f-bb9a-8d04f9ff9f44', NULL, 0, 0, NULL, 1, 0, N'mirakuru@gmail.com')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f75d3a7b-3cbc-4115-9697-cf9d8ece85d3', N'CanManageMovie')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'20cf8ca1-eb52-40fb-8351-bc524235698d', N'f75d3a7b-3cbc-4115-9697-cf9d8ece85d3')
");

        }

        public override void Down()
        {
        }
    }
}
