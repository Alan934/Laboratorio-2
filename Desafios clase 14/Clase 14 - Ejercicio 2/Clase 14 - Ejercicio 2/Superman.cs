using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_14___Ejercicio_2
{
    class Superman : SuperHeroe, IVolador
    {
        public void Volador()
        {
            Console.WriteLine("\nEstoy volando como un campeon...");
        }
    }
}
