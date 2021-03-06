﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //Arrange
            var bil = new Bil();
            
            //Act
            int pris = bil.Pris();
            

            //Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void KøreTøjTest()
        {
            //Arrange
            var bil = new Bil();

            //act
            string type = bil.KøreTøj();

            //Assert
            Assert.AreEqual("Bil", type);
        }
    }
}