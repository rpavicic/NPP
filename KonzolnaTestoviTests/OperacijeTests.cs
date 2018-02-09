using Microsoft.VisualStudio.TestTools.UnitTesting;
using KonzolnaTestovi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolnaTestovi.Tests
{
    [TestClass()]
    public class OperacijeTests
    {
        [TestMethod()]
        public void ZbrajanjeTest()
        {
            var Operacije = new Operacije();
            var rezultat = Operacije.Zbrajanje(2, 3);
            int tocanRezultat = 5;
            Assert.AreEqual(rezultat, tocanRezultat);
        }

        [TestMethod()]
        public void OduzimanjeTest()
        {
            var Operacije = new Operacije();
            var rezultat = Operacije.Oduzimanje(5, 2);
            int tocanRezultat = 3;
            Assert.AreEqual(rezultat, tocanRezultat);
        }
    }
}