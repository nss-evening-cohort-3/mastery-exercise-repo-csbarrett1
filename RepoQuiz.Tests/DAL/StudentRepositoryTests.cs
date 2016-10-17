using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;
using Moq;
using RepoQuiz.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class StudentRepositoryTests
    {
        private Mock<StudentContext> MockContext;
        private Mock<DbSet<Student>> Students;
        private List<Student> students;


        [TestInitialize]
        public void Setup()
        {
            MockContext = new Mock<StudentContext>();
            Students = new Mock<DbSet<Student>>();

            MockContext.Setup(x => x.Students).Returns(Students.Object);

            students = new List<Student>
            {
             new Student
             {
                  StudentID = 1,
                  FirstName = "Abraham",
                  LastName = "Lincoln",
                  Major = "History"
             },
             new Student
             {
                 StudentID = 2,
                 FirstName = "George",
                 LastName = "Washington",
                 Major = "Civics"
             },
             new Student
             {
                 StudentID = 3,
                 FirstName = "Thomas",
                 LastName = "Jefferson",
                 Major = "Algebra"
             }
            };

            ConnectMocksToDatastore();
        }

        public void ConnectMocksToDatastore()
        {
            var queryableStudents = students.AsQueryable();
            Students.As<IQueryable<Student>>().Setup(x => x.Provider).Returns(queryableStudents.Provider);
            Students.As<IQueryable<Student>>().Setup(x => x.Expression).Returns(queryableStudents.Expression);
            Students.As<IQueryable<Student>>().Setup(x => x.ElementType).Returns(queryableStudents.ElementType);
            Students.As<IQueryable<Student>>().Setup(x => x.GetEnumerator()).Returns(queryableStudents.GetEnumerator());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            MockContext = null;
            Students = null;
        }

        [TestMethod]
        public void EnsureICanCreateAnInstanceOfStudentRepo()
        {
            StudentRepository myRepo = new StudentRepository();
            Assert.IsNotNull(myRepo);
        }

        [TestMethod]
        public void EnsureMyRepoCanAccessContext()
        {
            StudentRepository myRepo = new StudentRepository(MockContext.Object);
        }
    }
}
