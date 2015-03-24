using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HiriKata.Models;
using HiriKata.Repos;
using System.Data.Entity;

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

        [TestMethod]
        public void TestGetHirigana() {
          var repo = new WordRepository();

          var words = repo.GetWords();
          Assert.AreEqual(words.Count, 48);
        }

        [TestMethod]
        public void TestCategories() {
          var repo = new WordRepository();

          var words = repo.GetCategories();
          Assert.AreEqual(words.Count, 5);
        }

        [TestMethod]
        public void hiriiskata() {
          Assert.AreEqual("ア", "あ");
          
        }
    }
}
