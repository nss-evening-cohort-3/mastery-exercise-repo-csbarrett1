namespace RepoQuiz.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<RepoQuiz.DAL.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepoQuiz.DAL.StudentContext context)
        {
            var myGen = new NameGenerator();

            var student1 = myGen.GenerateStudent();
            var student2 = myGen.GenerateStudent();
            var student3 = myGen.GenerateStudent();
            var student4 = myGen.GenerateStudent();
            var student5 = myGen.GenerateStudent();
            var student6 = myGen.GenerateStudent();
            var student7 = myGen.GenerateStudent();
            var student8 = myGen.GenerateStudent();
            var student9 = myGen.GenerateStudent();
            var student10 = myGen.GenerateStudent();

            context.Students.AddOrUpdate(x => x.StudentID, student1, student2, student3, student4, student5, student6, student7, student8, student9, student10);

        }
    }
}
