﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystemDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void BilPrisBBFalseTest()
        {
            //Arrange
            var bil = new Bil("1234567", Convert.ToDateTime("28-8-2017"), false, KøreTøj.BroType.Øresund);

            //Act
            int pris = bil.Pris();

            //Assert
            Assert.AreEqual(410, pris);
        }

        [TestMethod()]
        public void BilTypeTest()
        {
            //Arrange
            var bil = new Bil("1234567", Convert.ToDateTime("28-8-2017"), true, KøreTøj.BroType.Øresund);

            //Act
            string type = bil.Type();

            //Assert
            Assert.AreEqual("Bil", type);
        }

    }
}