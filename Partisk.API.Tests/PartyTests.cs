using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Partisk.API.Tests
{
    [TestClass]
    public class PartyTests
    {
        [TestCategory("AllInstances")]
        [TestMethod]
        public void TestGetParties()
        {
            var client = new PartiskClient();

            var parties = client.GetParties();

            client.Dispose();

            Assert.IsNotNull(parties);
            Assert.IsTrue(parties.Length > 3);
        }

        [TestCategory("SpecificInstance")]
        [TestMethod]
        public void TestGetParty()
        {
            // Set up
            var partyId = "2"; // 2 == moderaterna

            // Test
            var client = new PartiskClient();
            var party = client.GetParty(partyId);
            client.Dispose();

            // Assert
            Assert.IsNotNull(party);
        }
    }
}
