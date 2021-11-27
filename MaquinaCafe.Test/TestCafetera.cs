using MaquinaCafe.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaquinaCafe.Test
{
    [TestClass]
    public class TestCafetera
    {
        [TestMethod]
        public void DeveriaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.HasCafe(5);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void DeveriaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.HasCafe(11);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void DeveriaRestarCafeALaCafetera()
        {
            Cafetera cafetera = new Cafetera(10);
            cafetera.GiveCafe(7);
            Assert.AreEqual(3, cafetera.GetCantidadDeCafe());
        }
    }
}
