using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletSystemDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void MCPrisBBTrueeØSTest()
        {
            //Arrange
            var mc = new MC("1234567", Convert.ToDateTime("28-8-2017"), false, KøreTøj.BroType.Storbæltsbroen);

            //Act
            int pris = mc.Pris();

            //Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void MCTypeTest()
        {
            //Arrange
            var mc = new MC("1234567", Convert.ToDateTime("28-8-2017"), true, KøreTøj.BroType.Øresund);

            //Act
            string type = mc.Type();

            //Assert
            Assert.AreEqual("MC", type);
        }
    }
}