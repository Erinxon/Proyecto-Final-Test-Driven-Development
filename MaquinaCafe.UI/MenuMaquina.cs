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
                Console.WriteLine("1) Seleccionar el tamaño de vaso de café.");
                Console.WriteLine("2) Seleccionar las cucharadas de azúcar.");
                Console.WriteLine("3) Recoger vaso.");
                Console.WriteLine("4) Salir");
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
                            Console.WriteLine("Opción inválida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor intriduzca un numero valido");
                }
            } while (opcion != 4);
        }

        private void SeleccionarTipoVaso()
        {
            Console.WriteLine("  1) Vaso Pequeño -> 3 Oz de cafe");
            Console.WriteLine("  2) Vaso Mediano -> 5 Oz de cafe");
            Console.WriteLine("  3) Vaso Grande -> 7 Oz de cafe");
            bool isNumber = int.TryParse(Console.ReadLine(), out int opcionTipoVaso);
            if (isNumber)
            {
                switch (opcionTipoVaso)
                {
                    case 1:
                        vasoSelecionado = maquinaCafe.GetTipoDeVaso("pequeno");
                        break;
                    case 2:
                        vasoSelecionado = maquinaCafe.GetTipoDeVaso("mediano");
                        break;
                    case 3:
                        vasoSelecionado = maquinaCafe.GetTipoDeVaso("grande");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor intriduzca un numero valido");
                SeleccionarTipoVaso();
            }
        }

        private void SeleccionarCantidadCucharadasAzucar()
        {
            Console.WriteLine("Escriba las cucharadas de azucar");
            bool isNumber = int.TryParse(Console.ReadLine(), out cucharadasDeAzucar);
            if (!isNumber)
            {
                Console.WriteLine("Por favor intriduzca un numero valido");
                SeleccionarCantidadCucharadasAzucar();
            }
        }

        private void RecogerVaso()
        {
            if (vasoSelecionado is not null && cucharadasDeAzucar > 0)
            {
                string resultado = maquinaCafe.GetVasoDeCafe(vasoSelecionado, 1, cucharadasDeAzucar);
                Console.WriteLine(resultado);
                Limpiar();
            }
            else
            {
                Console.WriteLine("Por favor debe seleccionar el tipo de vaso y la cantidad de cucharadas de azucar");
            }
        }

        private void Limpiar()
        {
            this.vasoSelecionado = null;
            this.cucharadasDeAzucar = 0;
        }
    }
}
