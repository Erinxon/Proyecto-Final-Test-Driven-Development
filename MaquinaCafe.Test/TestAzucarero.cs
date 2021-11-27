using MaquinaCafe.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaquinaCafe.Test
{
    [TestClass]
    public class TestAzucarero
    {
        Azucarero azucarero;

        public TestAzucarero()
        {
            azucarero = new Azucarero(10);
        }

        [TestMethod]
        public void DeberiaDevolverVerdaderoSiHaySufucienteAzucarEnELAzucarero()
        {
            bool resultado = azucarero.HasAzucar(5);
            Assert.AreEqual(true, resultado);
            resultado = azucarero.HasAzucar(10);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoPorqueNoHaySufucienteAzucarEnELAzucarero()
        {
            bool resultado = azucarero.HasAzucar(11);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void DeberiaRestarAzucarAlAzucarero()
        {
            azucarero.GiveCantidadAzucar(5);
            Assert.AreEqual(5, azucarero.GetCantidadDeAzucar());
            azucarero.GiveCantidadAzucar(2);
            Assert.AreEqual(3, azucarero.GetCantidadDeAzucar());
        }
    }
}
