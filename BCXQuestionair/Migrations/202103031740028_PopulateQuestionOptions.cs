namespace BCXQuestionair.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateQuestionOptions : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO QuestionOptions ([Option], Question_Id) VALUES ('1 to 5', 2)");
            Sql("INSERT INTO QuestionOptions ([Option], Question_Id) VALUES ('6 to 25', 2)");
            Sql("INSERT INTO QuestionOptions ([Option], Question_Id) VALUES ('26 to 100', 2)");
            Sql("INSERT INTO QuestionOptions ([Option], Question_Id) VALUES ('101+', 2)");
            Sql("INSERT INTO QuestionOptions ([Option], Question_Id) VALUES ('Yes', 3)");
            Sql("INSERT INTO QuestionOptions ([Option], Question_Id) VALUES ('No', 3)");
        }
        
        public override void Down()
        {
        }
    }
}
