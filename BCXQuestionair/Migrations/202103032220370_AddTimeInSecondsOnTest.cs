namespace BCXQuestionair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTimeInSecondsOnTest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tests", "TimeinSeconds", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tests", "TimeinSeconds");
        }
    }
}
