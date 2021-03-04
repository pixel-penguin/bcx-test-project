namespace BCXQuestionair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateQuestionType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO QuestionTypes (Name) VALUES ('Input Field')");
            Sql("INSERT INTO QuestionTypes (Name) VALUES ('Multiple Options')");
        }
        
        public override void Down()
        {
        }
    }
}
