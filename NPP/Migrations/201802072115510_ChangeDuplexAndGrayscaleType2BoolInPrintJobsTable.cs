namespace NPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDuplexAndGrayscaleType2BoolInPrintJobsTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PrintJobs", "Duplex", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PrintJobs", "Grayscale", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PrintJobs", "Grayscale", c => c.String());
            AlterColumn("dbo.PrintJobs", "Duplex", c => c.String());
        }
    }
}
