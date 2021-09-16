using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoCompras
{
    class Menu
    {
        Camisas camisas = new Camisas();

        private float precio = 1000;
        public void MostrarMenu()
        {
            string opcionMenu;
            bool salir = false;
            do
            {
                Console.WriteLine("\nSHOPPING ONLINE DE CAMISAS - Ventas minoristas y mayoristas." +
                 "\n********************************************************************" +
                 "\nMenu Principal:" +
                 "\n(1) Añadir camisa al carro de compras." +
                 "\n(2) Eliminar camisa del carro de compras." +
                 "\n(3) Salir.)" +
                 "\n********************************************************************" +
                 "\n          - Cantidad de camisas en el carro de compas: " + camisas.MostrarCamisas()+
                 "\n          - Precio unitario: "+precio +
                 "\n          - Precio total sin descuento: "+ camisas.PrecioSinDescuento() +
                 "\n          - Tipo de descuento aplicado: "+camisas.TipoDescuento() +
                 "\n          - Precio final con descuento: "+camisas.PrecioTotal() +
                 "\n********************************************************************" +
                 "\nIngresar opcion: ");
                opcionMenu = Console.ReadLine();
                MenuAccion(opcionMenu, ref salir);
            } while (salir == false);      
        }

        public void MenuAccion(string opcionMenu, ref bool salir)
        {
            switch (opcionMenu)
            {
                case "1":
                    camisas.AgregarCamisas();
                    salir = false;
                    break;
                case "2":
                    camisas.EliminarCamisas();
                    salir = false;
                    break;
                case "3":
                    Console.Clear();
                    string opcionSalir;
                    Console.WriteLine("Estas seguro que desea salir? S/N");
                    opcionSalir = Console.ReadLine();
                    if (opcionSalir == "S" || opcionSalir == "s")
                    {
                        Console.WriteLine("Saliendo del programa...");
                        Environment.Exit(2);
                    }
                    else
                    {
                        Console.WriteLine("Reingresando al menu"+
                            "\nBienvenido devuelta!!");
                        salir = false;
                    }
                    break;
                default:
                    Console.WriteLine("La opción ingresada del menu es inválida, por favor reintente.");
                    salir = false;
                    break;
            }
        }



    }
}
