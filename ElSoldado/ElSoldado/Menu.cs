using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    class Menu
    {
        Rifle _rifle;
        Escopeta _escopeta;
        Revolver _revolver;
        Soldado _soldado;

        public Menu(ref Soldado soldado, ref Rifle rifle, ref Escopeta escopeta, ref Revolver revolver)
        {
            _soldado = soldado;
            _rifle = rifle;
            _escopeta = escopeta;
            _revolver = revolver;

            MostrarMenu();
        }

        public void MostrarMenu()
        {
            string opcion;
            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("-== Bienvenido al campo de entrenamiento, Soldado ==-");
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("(presione el número correspondiente a la opción del menú)");
                Console.WriteLine("");
                Console.WriteLine("1- Recoger Arma");
                Console.WriteLine("2- Dejar Arma");
                Console.WriteLine("3- Disparar");
                Console.WriteLine("4- Ver Arma en uso");
                Console.WriteLine("5- Salir");

                opcion = Console.ReadLine();

                MenuAccion(opcion, ref salir);
            } while (salir == false);
        }


        private void MenuAccion(string opcion, ref bool salir)
        {
            switch (opcion)
            {
                case "1":
                    MenuRecogerArma();
                    salir = false;
                    break;
                case "2":
                    _soldado.DejarArma();
                    Console.ReadKey();
                    salir = false;
                    break;
                case "3":
                    _soldado.JalarGatillo();
                    Console.ReadKey();
                    salir = false;
                    break;
                case "4":
                    _soldado.VerArma();
                    Console.ReadKey();
                    salir = false;
                    break;
                case "5":
                    Environment.Exit(2);
                    break;
                default:
                    Console.WriteLine("La opción ingresada es inválida, por favor reintente.");
                    Console.ReadKey();
                    salir = false;
                    break;
            }
        }

        private void MenuRecogerArma()
        {
            string opcion;
            bool opcionValida = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Por favor, escoja el arma que desea utilizar:");
                Console.WriteLine("");
                Console.WriteLine("1- Revolver");
                Console.WriteLine("2- Rifle");
                Console.WriteLine("3- Escopeta");
                Console.WriteLine("4- Volver atrás");

                opcion = Console.ReadLine();

                SeleccionarArma(opcion, ref opcionValida);

            } while (opcionValida == false);

            MostrarMenu();
        }

        private void SeleccionarArma(string opcion, ref bool opcionValida)
        {
            switch (opcion)
            {
                case "1":
                    _soldado.RecogerArma(_revolver);
                    opcionValida = true;
                    Console.ReadKey();
                    break;
                case "2":
                    _soldado.RecogerArma(_rifle);
                    opcionValida = true;
                    Console.ReadKey();
                    break;
                case "3":
                    _soldado.RecogerArma(_escopeta);
                    opcionValida = true;
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("Okay, el soldado no recogió ningún arma... Volveremos al menú principal.");
                    Console.ReadKey();
                    opcionValida = true;
                    break;
                default:
                    Console.WriteLine("La opción ingresada es inválida, por favor reintente.");
                    Console.ReadKey();
                    opcionValida = false;
                    break;
            }
        }
    
    }
}

