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
    public class KøreTøjTests
    {
        [TestMethod()]
        public void nummerPladeTest()
        {
            //Arrange
            var bil = new Bil("1234567", Convert.ToDateTime("28-8-2017"), true, KøreTøj.BroType.Øresund);

            //Act
            string nrPlade = bil.nummerPlade("1234567");

            //Assert
            Assert.AreEqual(bil.NummerPlade, nrPlade);
        }
    }
}