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
        [TestMethod]
        public void
    CostOfPastry_returnsTheCostOfThreePastrys_Pastry()
        {
            Pastry newPastry = new Pastry(3);
            Assert.AreEqual(6, newPastry.PastryCost());
        }
        [TestMethod]
        public void
        CostOfPastry_returnsTheCostOffourPastry_Pastry()
        {
            Pastry newPastry = new Pastry(4);
            Assert.AreEqual(6, newPastry.PastryCost());
        }
        [TestMethod]
        public void
            CostOfPastry_returnsTheCostOfFivePastry_Pastry()
        {
            Pastry newPastry = new Pastry(5);
            Assert.AreEqual(8, newPastry.PastryCost());
        }
        [TestMethod]
        public void
            CostOfPastry_returnsTheCostOfhugeOrderOfPastry_Pastry()
        {
            Pastry newPastry = new Pastry(300);
            Assert.AreEqual(450, newPastry.PastryCost());
        }
    }
}