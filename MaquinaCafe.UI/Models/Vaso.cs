using System;
using System.Collections.Generic;
using System.Text;

namespace MaquinaCafe.UI.Models
{
    public class Vaso
    {
        private int cantidadVasos;
        private int contenido;

        public Vaso()
        {

        }
        public Vaso(int cantidadVasos, int contenido)
        {
            this.SetCantidadVasos(cantidadVasos);
            this.SetContenido(contenido);     
        }

        public void SetCantidadVasos(int cantidad)
        {
            this.cantidadVasos = cantidad;
        }

        public int GetCantidadVasos()
        {
            return this.cantidadVasos;
        }

        public void SetContenido(int contenido)
        {
            this.contenido = contenido;
        }

        public int GetContenido()
        {
            return this.contenido;
        }

        public bool HasVasos(int cantidadVasos)
        {
            return this.cantidadVasos >= cantidadVasos;
        }

        public void GiveVasos(int cantidad)
        {
            this.cantidadVasos -= cantidad;
        }


    }
}
