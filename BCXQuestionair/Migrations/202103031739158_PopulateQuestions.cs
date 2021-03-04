namespace BCXQuestionair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateQuestions : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Questions (QuestionString, QuestionType_Id) VALUES ('Where did you hear from us, and what do you think will make you a great asset to the BCX Business Application Department?', 1)");
            Sql("INSERT INTO Questions (QuestionString, QuestionType_Id) VALUES ('How many software solutions did you write in your life?', 2)");
            Sql("INSERT INTO Questions (QuestionString, QuestionType_Id) VALUES ('Was it fun building a website for an interview?', 2)");
        }
        
        public override void Down()
        {
        }
    }
}
