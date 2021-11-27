using MaquinaCafe.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafe.UI
{
    public class MenuMaquina
    {
        private Cafetera cafetera;
        private Vaso vasoPequeno;
        private Vaso vasoMediano;
        private Vaso vasoGrande;
        private Azucarero azucarero;
        private MaquinaDeCafe maquinaCafe;

        private Vaso vasoSelecionado = null;
        private int cantidadVasos = 0;
        private int cucharadasDeAzucar = 0;

        public MenuMaquina()
        {
            this.cafetera = new(50);
            this.vasoPequeno = new(5, 10);
            this.vasoMediano = new(5, 20);
            this.vasoGrande = new(5, 30);
            this.azucarero = new(20);

            this.maquinaCafe = new();
            this.maquinaCafe.SetCafetera(cafetera);
            this.maquinaCafe.SetVasosPequeno(vasoPequeno);
            this.maquinaCafe.SetVasosMediano(vasoMediano);
            this.maquinaCafe.SetVasosGrande(vasoGrande);
            this.maquinaCafe.SetAzucarero(azucarero);
        }

        public void MostrarMenu()
        {
            int opcion = 0;
            do
            {
                Print("1) Seleccionar el tamaño de vaso de café.");
                Print("2) Seleccionar las cucharadas de azúcar.");
                Print("3) Recoger vaso.");
                Print("4) Salir");
                bool isNumber = int.TryParse(Console.ReadLine(), out opcion);
                if (isNumber)
                {
                    switch (opcion)
                    {
                        case 1:
                            this.SeleccionarTipoVaso();
                            break;
                        case 2:
                            this.SeleccionarCantidadCucharadasAzucar();
                            break;
                        case 3:
                            this.RecogerVaso();
                            break;
                        case 4:
                            break;
                        default:
                            Print("Opción inválida");
                            break;
                    }
                }
                else
                {
                    Print("Por favor intriduzca un numero valido");
                }
            } while (opcion != 4);
        }

        private void SeleccionarTipoVaso()
        {
            Print("  1) Vaso Pequeño -> 3 Oz de cafe");
            Print("  2) Vaso Mediano -> 5 Oz de cafe");
            Print("  3) Vaso Grande -> 7 Oz de cafe");
            int opcionTipoVaso = Input("");
            switch (opcionTipoVaso)
            {
                case 1:
                    vasoSelecionado = maquinaCafe.GetTipoDeVaso("pequeno");
                    SeleccionarCantidadDeVasos();
                    break;
                case 2:
                    vasoSelecionado = maquinaCafe.GetTipoDeVaso("mediano");
                    SeleccionarCantidadDeVasos();
                    break;
                case 3:
                    vasoSelecionado = maquinaCafe.GetTipoDeVaso("grande");
                    SeleccionarCantidadDeVasos();
                    break;
                default:
                    Print("Opción inválida");
                    break;
            }
        }

        private void SeleccionarCantidadDeVasos()
        {
            this.cantidadVasos = Input("Escriba la cantidad de vasos");
        }

        private void SeleccionarCantidadCucharadasAzucar()
        {
            this.cucharadasDeAzucar = Input("Escriba las cucharadas de azucar");
        }

        private void RecogerVaso()
        {
            if (vasoSelecionado is not null && cucharadasDeAzucar > 0 && cantidadVasos > 0)
            {
                string resultado = maquinaCafe.GetVasoDeCafe(vasoSelecionado, cantidadVasos, cucharadasDeAzucar);
                Print(resultado);
                Resetear();
            }
            else
            {
                Print("Por favor asegurese de haber selecionado el tipo de vaso, la cantidad de vasos y las cucharadas de azucar");
            }
        }

        private void Resetear()
        {
            this.vasoSelecionado = null;
            this.cucharadasDeAzucar = 0;
            this.cantidadVasos = 0;
        }

        private void Print(string text)
        {
            Console.WriteLine(text);
        }

        private int Input(string text)
        {
            Print(text);
            bool isNumber = int.TryParse(Console.ReadLine(), out int numero);
            if (!isNumber)
            {
                Print("Por favor ingrese un número valido");
                return Input(text);
            }
            return numero;
        }
    }
}
