using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]

        public void
    PastryConstructor_CreatesInstanceOfPastry_Pastry()
        {
            Pastry newPastry = new Pastry();
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }

        [TestMethod]

        public void
    CostOfPastry_returnsTheCostOfTwoPastry_Pastry()
        {
            Pastry newPastry = new Pastry(2);
            Assert.AreEqual(4, newPastry.PastryCost());

        }

    }
}