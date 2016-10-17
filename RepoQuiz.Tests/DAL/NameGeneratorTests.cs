using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class NameGeneratorTests
    {
        [TestMethod]
        public void CanCreateInstanceOfRandom()
        {
            Random myRand = new Random();
            Assert.IsNotNull(myRand);
        }
    }
}
