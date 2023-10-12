using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesFlotte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte.Tests
{
    [TestClass()]
    public class UtilitaireTests
    {
        [TestMethod()]
        public void ChargeUtileTest()
        {
            Utilitaire  utilitaire = new Utilitaire(500, 300 ,15, "AA-125-BB", "Essence", 130 );
            
        }

        [TestMethod()]
        public void PrevoirEntretienTest()
        {
            // TODO
        }
    }
}