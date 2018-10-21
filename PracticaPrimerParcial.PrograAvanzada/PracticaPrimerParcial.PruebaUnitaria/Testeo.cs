using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticaPrimerParcial.PruebaUnitaria
{
    [TestClass]
    public class Testeo
    {
        [TestMethod]
        public void TrianguloPerimetroLadosPositivos()
        {
            var L1 = 2;
            var L2 = 4;
            var L3 = 5;
            var ValorEsperado = 11;
            var ValorReal = 0.0;

            var elServicio = new ServiceWCF.Service1();
            ValorReal = elServicio.PerimetroTriangulo(L1, L2, L3);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        [TestMethod]
        public void TrianguloPerimetroLadosNegativos()
        {
            var L1 = 2;
            var L2 = -4;
            var L3 = 5;
            var ValorEsperado = 0.0;
            var ValorReal = 0.0;

            var elServicio = new ServiceWCF.Service1();
            ValorReal = elServicio.PerimetroTriangulo(L1, L2, L3);

            Assert.AreEqual(ValorEsperado, ValorReal);
        }

        
    }
}
