using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Partisk.API.Tests
{
    [TestClass]
    public class TagTests
    {
        [TestCategory("AllInstances")]
        [TestMethod]
        public void TestGetTags()
        {
            var client = new PartiskClient();

            var tags = client.GetTags();

            client.Dispose();

            Assert.IsNotNull(tags);
            Assert.IsTrue(tags.Length > 10);
        }

        [TestCategory("SpecificInstance")]
        [TestMethod]
        public void TestGetTag()
        {
            // Set up
            var tagId = "261"; // 261 = aga

            // Test
            var client = new PartiskClient();
            var tag = client.GetTag(tagId);
            client.Dispose();

            // Assert
            Assert.IsNotNull(tag);
        }
    }
}
