using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;
//add   passing test for new instance of the Bread class w/qty of 2

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
        public void costOfBread_ReturnsTheCostOfOneLoafof_Bread()
        {
            Bread newBread = new Bread(1);
            Assert.AreEqual(5, newBread.BreadCost());
        }

        [TestMethod]
        public void costOfBread_ReturnTheCostOfTwoLoavesof_Bread()
        {
            Bread newBread = new Bread(2);
            Assert.AreEqual(10, newBread.BreadCost());
        }

        [TestMethod] //#3
        public void costOfBread_ReturnTheCostOfThreeLoavesof_Bread()
        {
            Bread newBread = new Bread(3);
            Assert.AreEqual(10, newBread.BreadCost());

        }
        [TestMethod] //#4

        public void costOfBread_ReturnTheCostOfFourLoavesof_Bread()
        {
            Bread newBread = new Bread(4);
            Assert.AreEqual(15, newBread.BreadCost());

        }

        

    }

}

