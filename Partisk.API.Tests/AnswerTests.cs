using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Partisk.API.Tests
{
    [TestClass]
    public class AnswerTests
    {
        [TestCategory("AllInstances")]
        [TestMethod]
        public void TestGetAnswers()
        {
            // Test
            var client = new PartiskClient();
            var answers = client.GetAnswers();
            client.Dispose();

            // Assert
            Assert.IsNotNull(answers);
            Assert.IsTrue(answers.Length > 3);
        }

        [TestCategory("SpecificInstance")]
        [TestMethod]
        public void TestGetAnswer()
        {
            // Set up
            var answerId = "18";            

            // Test
            var client = new PartiskClient();
            var answer = client.GetAnswer(answerId);
            client.Dispose();

            // Assert
            Assert.IsNotNull(answer);
        }
    }
}
