using RepoQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepoQuiz.DAL
{
    public class StudentRepository
    {
        private StudentContext Context { get; set; }

        public StudentRepository(StudentContext _context)
        {
            Context = _context;
        }

        // Create new repo
        public StudentRepository()
        {
            Context = new StudentContext();
        }

        // Get all Students
        public List<Student> GetAllStudents()
        {
            return Context.Students.ToList();
        }
    }
}