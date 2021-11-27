using System;
using System.Collections.Generic;
using System.Text;

namespace MaquinaCafe.UI.Models
{
    public class Cafetera
    {
        private int cantidadCafe;

        public Cafetera()
        {

        }
        public Cafetera(int cantidadCafe)
        {
            this.SetCantidadDeCafe(cantidadCafe);
        }
        public void SetCantidadDeCafe(int cantidad)
        {
            this.cantidadCafe = cantidad;
        }

        public int GetCantidadDeCafe()
        {
            return this.cantidadCafe;
        }

        public bool HasCafe(int cantidad)
        {
            return this.cantidadCafe >= cantidad;
        }

        public void GiveCafe(int cantidad)
        {
            this.cantidadCafe -= cantidad;
        }
    }
}
