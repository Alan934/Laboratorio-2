using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero1;
            int numero2;

            Console.WriteLine("Ingrese el numero 1: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Operacion.Suma(numero1, numero2);
            Operacion.Resta(numero1, numero2);

        }
    }
}
