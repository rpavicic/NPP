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
    public class StringoviTests
    {
        [TestMethod()]
        public void SloziRecenicuOdRijeciTest()
        {
            Stringovi objekt = new Stringovi();
            string ocekivano = "Danas je lijep dan.";
            string[] testneRijeci = new string[] { "Danas", "je", "lijep", "dan" };
            string rezultat = objekt.SloziRecenicuOdRijeci(testneRijeci);

            Assert.AreEqual<string>(ocekivano, rezultat);
        }
    }
}