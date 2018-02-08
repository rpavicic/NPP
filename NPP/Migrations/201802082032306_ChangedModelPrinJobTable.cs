namespace NPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedModelPrinJobTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PrintJobs", "Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PrintJobs", "Time", c => c.DateTime(nullable: false));
        }
    }
}
