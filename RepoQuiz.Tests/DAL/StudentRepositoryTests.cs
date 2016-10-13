using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;
using Moq;
using RepoQuiz.Models;
using System.Data.Entity;
using System.Collections.Generic;

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


        }

        [TestMethod]
        public void EnsureICanCreateAnInstanceOfStudentRepo()
        {
            StudentRepository myRepo = new StudentRepository();
            Assert.IsNotNull(myRepo);
        }
    }
}
