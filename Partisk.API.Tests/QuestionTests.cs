using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Partisk.API.Tests
{
    [TestClass]
    public class QuestionTests
    {
        [TestCategory("AllInstances")]
        [TestMethod]
        public void TestGetQuestions()
        {
            var client = new PartiskClient();

            var questions = client.GetQuestions();

            client.Dispose();

            Assert.IsNotNull(questions);
            Assert.IsTrue(questions.Length > 3);
        }

        [TestCategory("SpecificInstance")]
        [TestMethod]
        public void TestGetQuestion()
        {
            var client = new PartiskClient();

            var question = client.GetQuestion("2");

            client.Dispose();

            Assert.IsNotNull(question);
        }
    }
}
