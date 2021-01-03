namespace 研招网系统.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Answer",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Content = c.String(),
                        Way = c.String(maxLength: 50),
                        Qid = c.Guid(nullable: false),
                        User_Id = c.Guid(),
                        User_Id1 = c.Guid(),
                        User1_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .ForeignKey("dbo.User", t => t.User_Id1)
                .ForeignKey("dbo.User", t => t.UserId)
                .ForeignKey("dbo.User", t => t.User1_Id)
                .Index(t => t.UserId)
                .Index(t => t.User_Id)
                .Index(t => t.User_Id1)
                .Index(t => t.User1_Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Sex = c.Int(),
                        SchoolId = c.Guid(),
                        Major = c.String(maxLength: 50),
                        Colleges = c.String(maxLength: 50),
                        Area = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.School", t => t.SchoolId)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.School",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.Binary(nullable: false, maxLength: 50),
                        Password = c.Binary(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Information",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CategoryId = c.Guid(),
                        SchoolId = c.Guid(),
                        PulishTime = c.Time(precision: 7),
                        Title = c.String(maxLength: 50),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId)
                .ForeignKey("dbo.School", t => t.SchoolId)
                .Index(t => t.CategoryId)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Policy",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CategoryId = c.Guid(),
                        PulishTime = c.Time(precision: 7),
                        Title = c.String(maxLength: 50),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(),
                        Title = c.String(maxLength: 50),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answer", "User1_Id", "dbo.User");
            DropForeignKey("dbo.Answer", "UserId", "dbo.User");
            DropForeignKey("dbo.User", "SchoolId", "dbo.School");
            DropForeignKey("dbo.Information", "SchoolId", "dbo.School");
            DropForeignKey("dbo.Policy", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.Information", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.Answer", "User_Id1", "dbo.User");
            DropForeignKey("dbo.Answer", "User_Id", "dbo.User");
            DropIndex("dbo.Policy", new[] { "CategoryId" });
            DropIndex("dbo.Information", new[] { "SchoolId" });
            DropIndex("dbo.Information", new[] { "CategoryId" });
            DropIndex("dbo.User", new[] { "SchoolId" });
            DropIndex("dbo.Answer", new[] { "User1_Id" });
            DropIndex("dbo.Answer", new[] { "User_Id1" });
            DropIndex("dbo.Answer", new[] { "User_Id" });
            DropIndex("dbo.Answer", new[] { "UserId" });
            DropTable("dbo.Question");
            DropTable("dbo.Policy");
            DropTable("dbo.Category");
            DropTable("dbo.Information");
            DropTable("dbo.School");
            DropTable("dbo.User");
            DropTable("dbo.Answer");
            DropTable("dbo.Admin");
        }
    }
}
