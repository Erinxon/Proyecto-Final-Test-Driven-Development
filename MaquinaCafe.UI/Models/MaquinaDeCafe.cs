using System;
using System.Collections.Generic;
using System.Text;

namespace MaquinaCafe.UI.Models
{
    public class MaquinaDeCafe
    {
        public Cafetera cafe;
        public Vaso vasosPequenos;
        public Vaso vasosMedianos;
        public Vaso vasosGrandes;
        public Azucarero azucar;


        public void SetCafetera(Cafetera cafetera)
        {
            this.cafe = cafetera;
        }

        public Cafetera GetCafetera()
        {
            return this.cafe;
        }

        public void SetAzucarero(Azucarero azucarero)
        {
            this.azucar = azucarero;
        }

        public Azucarero GetAzucarero()
        {
            return this.azucar;
        }

        public void SetVasosPequeno(Vaso vaso)
        {
            this.vasosPequenos = vaso;
        }

        public Vaso GetVasosPequenos()
        {
            return this.vasosPequenos;
        }

        public void SetVasosMediano(Vaso vaso)
        {
            this.vasosMedianos = vaso;
        }
        public Vaso GetVasosMedianos()
        {
            return this.vasosMedianos;
        }

        public void SetVasosGrande(Vaso vaso)
        {
            this.vasosGrandes = vaso;
        }

        public Vaso GetVasosGrandes()
        {
            return this.vasosGrandes;
        }

        public Vaso GetTipoDeVaso(string tipoVaso) => tipoVaso switch
        {
            "pequeno" => this.vasosPequenos,
            "mediano" => this.vasosMedianos,
            "grande" => this.vasosGrandes,
            _ => throw new ArgumentOutOfRangeException(nameof(tipoVaso), $"Not expected direction value: {tipoVaso}"),
        };

        public string GetVasoDeCafe(Vaso tipoVaso, int cantidadVasos, int cantidadAzucar)
        {
            if (!tipoVaso.HasVasos(cantidadVasos)) return "No hay vasos";
            if (!this.cafe.HasCafe(tipoVaso.GetContenido())) return "No hay cafe";
            if (!this.azucar.HasAzucar(cantidadAzucar)) return "No hay azucar";
            tipoVaso.GiveVasos(cantidadVasos);
            this.cafe.GiveCafe(tipoVaso.GetContenido());   
            this.azucar.GiveCantidadAzucar(cantidadAzucar);
            return "Felicitaciones";
        }

    }
}
