using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoCompras
{
    class Camisas
    {
        public int cantCamisas;
        private float precio = 1000;
        private double precio1=0;
        private int cantCamisasTotal = 0;

        public void AgregarCamisas()
        {
            
            Console.WriteLine("Ingrese cuantas camisas desea agregar:");
            cantCamisas = Convert.ToInt32(Console.ReadLine());
            cantCamisasTotal += cantCamisas;
        }

        public void EliminarCamisas()
        {
            if (cantCamisasTotal <=0)
            {
                Console.WriteLine("\nNo tiene camisas agregadas");
            }
            else
            {
                Console.WriteLine("Ingrese cuantas camisas desea eliminar:");
                int eliminarCamisas = Convert.ToInt32(Console.ReadLine());
                cantCamisasTotal -= eliminarCamisas;
            }
        }
        public int MostrarCamisas()
        {
            return cantCamisasTotal;
        }

        public float PrecioSinDescuento()
        {
            return cantCamisasTotal * precio;
        }

        public double TipoDescuento()
        {
            if (cantCamisasTotal >= 6)
            {
                return precio1 = (precio * cantCamisasTotal) * 0.2;
            }
            if (cantCamisasTotal >= 3 || cantCamisasTotal <=5)
            {
                return precio1 = (precio * cantCamisasTotal) * 0.1;
            }
            else
            {
                return precio1;
            }
        }

        public double PrecioTotal()
        {
            if (cantCamisasTotal < 3)
            {
                return precio * cantCamisasTotal;
            }
            else
            {
                return (precio*cantCamisasTotal) - precio1;
            }
            
        }
    }
}
