namespace ChatBot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class courseNumberAdded1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "time", c => c.String());
            AddColumn("dbo.Courses", "location", c => c.String());
            AddColumn("dbo.Courses", "noOfUnits", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "noOfUnits");
            DropColumn("dbo.Courses", "location");
            DropColumn("dbo.Courses", "time");
        }
    }
}
