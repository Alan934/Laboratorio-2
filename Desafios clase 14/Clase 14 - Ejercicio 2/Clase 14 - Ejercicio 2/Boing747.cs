using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_14___Ejercicio_2
{
    class Boing747 : Avion, IVolador
    {
        public void Volador()
        {
            Console.WriteLine("\nEstoy volando como un avion.");
        }
    }
}
