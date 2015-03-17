using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HiriKata.Models;

namespace TestHiri
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUserHashing()
        {
            var bob = new Users("Bob", "abc123");
            Assert.AreEqual(true, bob.checkPass("abc123"));
        }
    }
}
