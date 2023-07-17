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

        [TestMethod] 
        public void costOfBread_ReturnTheCostOfThreeLoavesof_Bread()
        {
            Bread newBread = new Bread(3);
            Assert.AreEqual(10, newBread.BreadCost());

        }
        [TestMethod] 

        public void costOfBread_ReturnTheCostOfFourLoavesof_Bread()
        {
            Bread newBread = new Bread(4);
            Assert.AreEqual(15, newBread.BreadCost());

        }
        [TestMethod]

        public void costOfBread_ReturnTheCostOfFiveLoavesof_Bread()
        {
            Bread newBread = new Bread(5);
            Assert.AreEqual(20, newBread.BreadCost());

        }
        public void costOfBread_ReturnTheCostOfHugeLoavesof_Bread()
        {
            Bread newBread = new Bread(300);
            Assert.AreEqual(1000, newBread.BreadCost());
        }



    }

}

