using System;
using MaquinaCafe.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaquinaCafe.Test
{

    [TestClass]
    public class TestVaso
    {
        [TestMethod]
        public void DeberiaDevolverVerdaderoSiExistenVasos()
        {
            Vaso vasoPequenos = new Vaso(2,10);

            bool resultado = vasoPequenos.HasVasos(1);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoSiExistenVasos()
        {
            Vaso vasoPequenos = new Vaso(1, 10);

            bool resultado = vasoPequenos.HasVasos(2);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void DeberiaRestarCantidadDeVasos()
        {
            Vaso vasoPequenos = new Vaso(5, 10);

            vasoPequenos.GiveVasos(1);

            Assert.AreEqual(4, vasoPequenos.GetCantidadVasos());
        }
    }
}
