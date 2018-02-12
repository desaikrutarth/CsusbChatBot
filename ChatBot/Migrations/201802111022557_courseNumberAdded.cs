namespace ChatBot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class courseNumberAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "number", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "number");
        }
    }
}
