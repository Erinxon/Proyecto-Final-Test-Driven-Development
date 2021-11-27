using System;
using System.Collections.Generic;
using System.Text;

namespace MaquinaCafe.UI.Models
{
    public class Azucarero
    {
        private int cantidadDeAzucar;

        public Azucarero()
        {

        }
        public Azucarero(int cantidadDeAzucar)
        {
            this.SetCantidadDeAzucar(cantidadDeAzucar);
        }

        public void SetCantidadDeAzucar(int cantidad)
        {
            this.cantidadDeAzucar = cantidad;
        }

        public int GetCantidadDeAzucar()
        {
            return this.cantidadDeAzucar;
        }

        public bool HasAzucar(int cantidad)
        {
            return this.cantidadDeAzucar >= cantidad;
        }

        public void GiveCantidadAzucar(int cantidad)
        {
            this.cantidadDeAzucar -= cantidad;
        }


    }
}
