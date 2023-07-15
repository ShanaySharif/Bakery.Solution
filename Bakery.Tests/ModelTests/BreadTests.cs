using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
    [TestClass]
    public class BakeryTests
    {
        [TestMethod]

        public void
    BreadConstructor_CreatesInstanceOfbread_Bread()
        {
            Bread newBread = new Bread();
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void FindingBreadCost_ReturnsTheCostOfOneLoaf_Bread()
        {
            Bread newBread = new Bread(1);
            Assert.AreEqual(5, newBread.BreadCost());
        }

    }

}