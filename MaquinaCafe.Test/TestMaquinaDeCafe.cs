using MaquinaCafe.UI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaquinaCafe.Test
{
    [TestClass]
    public class TestMaquinaDeCafe
    {
        Cafetera cafetera;
        Vaso vasoPequeno;
        Vaso vasoMediano;
        Vaso vasoGrande;
        Azucarero azucarero;
        MaquinaDeCafe maquinaCafe;
        public TestMaquinaDeCafe()
        {
            this.cafetera = new Cafetera(50);
            this.vasoPequeno = new Vaso(5, 10);
            this.vasoMediano = new Vaso(5, 20);
            this.vasoGrande = new Vaso(5, 30);
            this.azucarero = new Azucarero(20);

            this.maquinaCafe = new MaquinaDeCafe();
            this.maquinaCafe.SetCafetera(cafetera);
            this.maquinaCafe.SetVasosPequeno(vasoPequeno);
            this.maquinaCafe.SetVasosMediano(vasoMediano);
            this.maquinaCafe.SetVasosGrande(vasoGrande);
            this.maquinaCafe.SetAzucarero(azucarero);
        }
            
        [TestMethod]
        public void DeberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = this.maquinaCafe.GetTipoDeVaso("pequeno");
            Assert.AreEqual(this.maquinaCafe.vasosPequenos, vaso);
        }

        [TestMethod]
        public void DeberiaDevolverUnVasoMediano()
        {
            Vaso vaso = this.maquinaCafe.GetTipoDeVaso("mediano");
            Assert.AreEqual(this.maquinaCafe.vasosMedianos, vaso);
        }

        [TestMethod]
        public void DeberiaDevolverUnVasoGrande()
        {
            Vaso vaso = this.maquinaCafe.GetTipoDeVaso("grande");
            Assert.AreEqual(this.maquinaCafe.vasosGrandes, vaso);
        }

        [TestMethod]
        public void DeberiaDevolverNoHayVasos()
        {
            Vaso vaso = this.maquinaCafe.GetTipoDeVaso("pequeno");
            string resultado = this.maquinaCafe.GetVasoDeCafe(vaso, 10, 2);
            Assert.AreEqual("No hay vasos", resultado);
        }

        [TestMethod]
        public void DeberiaDevolverNoHayCafe()
        {
            this.cafetera = new Cafetera(5);
            this.maquinaCafe.SetCafetera(cafetera);

            Vaso vaso = this.maquinaCafe.GetTipoDeVaso("pequeno");
            string resultado = this.maquinaCafe.GetVasoDeCafe(vaso, 1, 2);
            Assert.AreEqual("No hay cafe", resultado);
        }

        [TestMethod]
        public void DeberiaDevolverNoHayAzucar()
        {
            this.azucarero = new Azucarero(2);
            this.maquinaCafe.SetAzucarero(azucarero);

            Vaso vaso = this.maquinaCafe.GetTipoDeVaso("pequeno");
            string resultado = this.maquinaCafe.GetVasoDeCafe(vaso, 1, 3);
            Assert.AreEqual("No hay azucar", resultado);
        }

        [TestMethod]
        public void DeberiaDevolverRestarElCafe()
        {
            Vaso vaso = this.maquinaCafe.GetTipoDeVaso("pequeno");
            this.maquinaCafe.GetVasoDeCafe(vaso, 1, 3);
            int resultado = this.maquinaCafe.GetCafetera().GetCantidadDeCafe();
            Assert.AreEqual(40, resultado);
        }

        [TestMethod]
        public void DeberiaDevolverRestarVaso()
        {
            Vaso vaso = this.maquinaCafe.GetTipoDeVaso("pequeno");
            this.maquinaCafe.GetVasoDeCafe(vaso, 1, 3);
            int resultado = this.maquinaCafe.GetVasosPequenos().GetCantidadVasos();
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void DeberiaDevolverRestarAzucar()
        {
            Vaso vaso = this.maquinaCafe.GetTipoDeVaso("pequeno");
            this.maquinaCafe.GetVasoDeCafe(vaso, 1, 3);
            int resultado = this.maquinaCafe.GetAzucarero().GetCantidadDeAzucar();
            Assert.AreEqual(17, resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFelicitaciones()
        {
            Vaso vaso = this.maquinaCafe.GetTipoDeVaso("pequeno");
            string resultado = this.maquinaCafe.GetVasoDeCafe(vaso, 1, 3);
            Assert.AreEqual("Felicitaciones", resultado);
        }

    }
}
