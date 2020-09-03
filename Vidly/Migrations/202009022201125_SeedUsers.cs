namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0ebc90eb-b35a-4a23-a92a-a9c87efe8d1e', N'guest@in.com', 0, N'AIB3bluL7Ze6uRfRr4rkR+8j/zDUjhbhVepuhA07BT09E/7hc6e4G0IhwwF9/pakrg==', N'1871384e-4dc9-4a42-b5b2-e8f944cf68ad', NULL, 0, 0, NULL, 1, 0, N'guest@in.com');
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b9497231-3fb1-41c8-9858-e8d0129f9af5', N'admin@in.com', 0, N'AFiiDhoBfHhGRCUhLs+hdJIxhxCWTte+lKJsFQ1O19g79dnfkodZZzXIv8vll7co9A==', N'dd40e861-6404-4e3b-b07f-69bd029e983f', NULL, 0, 0, NULL, 1, 0, N'admin@in.com');

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9d414b83-c764-4ae9-a051-8473009d90a1', N'CanManageMovies');

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b9497231-3fb1-41c8-9858-e8d0129f9af5', N'9d414b83-c764-4ae9-a051-8473009d90a1');
                ");


        }
        
        public override void Down()
        {
        }
    }
}
