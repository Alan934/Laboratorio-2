using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio
{
    class Operacion
    {
        public static void Suma(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            Console.WriteLine("La suma de los 2 numeros es: "+resultado);
        }

        public static void Resta(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            Console.WriteLine("La resta de los 2 numeros es: " + resultado);
        }

    }
}
