namespace NPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedmodel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Name");
            DropColumn("dbo.Users", "Surname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Surname", c => c.String());
            AddColumn("dbo.Users", "Name", c => c.String());
        }
    }
}
