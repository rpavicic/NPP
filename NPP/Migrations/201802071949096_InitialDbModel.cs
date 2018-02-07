namespace NPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDbModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ComputerName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Printers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrintJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Pages = c.Int(nullable: false),
                        Copies = c.Int(nullable: false),
                        DocumentName = c.String(),
                        PaperSize = c.String(),
                        PrintLanguage = c.String(),
                        Height = c.String(),
                        Width = c.String(),
                        Duplex = c.String(),
                        Grayscale = c.String(),
                        DocumentSize = c.String(),
                        Computer_Id = c.Int(),
                        Printer_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Computers", t => t.Computer_Id)
                .ForeignKey("dbo.Printers", t => t.Printer_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Computer_Id)
                .Index(t => t.Printer_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Uid = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrintJobs", "User_Id", "dbo.Users");
            DropForeignKey("dbo.PrintJobs", "Printer_Id", "dbo.Printers");
            DropForeignKey("dbo.PrintJobs", "Computer_Id", "dbo.Computers");
            DropIndex("dbo.PrintJobs", new[] { "User_Id" });
            DropIndex("dbo.PrintJobs", new[] { "Printer_Id" });
            DropIndex("dbo.PrintJobs", new[] { "Computer_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.PrintJobs");
            DropTable("dbo.Printers");
            DropTable("dbo.Computers");
        }
    }
}
