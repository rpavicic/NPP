namespace NPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeComputerName2ComputerTableComputer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Computers", "Name", c => c.String());
            DropColumn("dbo.Computers", "ComputerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Computers", "ComputerName", c => c.String());
            DropColumn("dbo.Computers", "Name");
        }
    }
}
