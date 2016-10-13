using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepoQuiz.DAL
{
    public class StudentRepository
    {
        private StudentContext Context { get; set; }

        public StudentRepository(StudentContext context)
        {
            Context = context;
        }

        public StudentRepository()
        {
            Context = new StudentContext();
        }
     
    }
}