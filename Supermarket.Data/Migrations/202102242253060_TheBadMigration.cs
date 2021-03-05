namespace Supermarket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TheBadMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DeparnmentId = c.Int(nullable: false),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DeparnmentId = c.Int(nullable: false),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Products", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Workers", new[] { "Department_Id" });
            DropIndex("dbo.Products", new[] { "Department_Id" });
            DropTable("dbo.Workers");
            DropTable("dbo.Products");
            DropTable("dbo.Departments");
        }
    }
}
