namespace ChatBot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneChangedDatatype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Professors", "phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Professors", "phone", c => c.Long(nullable: false));
        }
    }
}
