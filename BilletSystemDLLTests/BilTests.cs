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

            //Act
            string type = bil.KøreTøj();

            //Assert
            Assert.AreEqual("Bil", type);
        }
    }
}