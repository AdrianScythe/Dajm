using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dajm;

namespace Dajm_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Tilføj()
        {
            ConsoleComands Klasse = new ConsoleComands();
            Klasse.Efternavn = "Johannes";
            Klasse.Fornavn = "Martin";
            Klasse.Hold = "B";
            Klasse.ID = 1;
            Reposetory rep = new Dajm.Reposetory();
            int NumItem = rep.Tælle();
            Assert.AreEqual(0, NumItem);
            rep.Tilføj(Klasse);
            NumItem = rep.Tælle();
            Assert.AreEqual(1, NumItem);
        }
        [TestMethod]
        public void Slet()
        {

        }
    }
}
