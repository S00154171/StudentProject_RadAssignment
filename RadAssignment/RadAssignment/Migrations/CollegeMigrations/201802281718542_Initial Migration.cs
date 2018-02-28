namespace RadAssignment.Migrations.CollegeMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassesID = c.Int(nullable: false, identity: true),
                        ClasseseName = c.String(),
                        ModuleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassesID)
                .ForeignKey("dbo.Module", t => t.ModuleID, cascadeDelete: true)
                .Index(t => t.ModuleID);
            
            CreateTable(
                "dbo.Module",
                c => new
                    {
                        ModuleID = c.Int(nullable: false, identity: true),
                        ModuleName = c.String(),
                        LectureID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModuleID)
                .ForeignKey("dbo.Lecture", t => t.LectureID, cascadeDelete: true)
                .Index(t => t.LectureID);
            
            CreateTable(
                "dbo.Lecture",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        LectureFirstName = c.String(),
                        LectureLastName = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ModuleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Classes", t => t.ModuleID, cascadeDelete: true)
                .Index(t => t.ModuleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "ModuleID", "dbo.Classes");
            DropForeignKey("dbo.Classes", "ModuleID", "dbo.Module");
            DropForeignKey("dbo.Module", "LectureID", "dbo.Lecture");
            DropIndex("dbo.Student", new[] { "ModuleID" });
            DropIndex("dbo.Module", new[] { "LectureID" });
            DropIndex("dbo.Classes", new[] { "ModuleID" });
            DropTable("dbo.Student");
            DropTable("dbo.Lecture");
            DropTable("dbo.Module");
            DropTable("dbo.Classes");
        }
    }
}
