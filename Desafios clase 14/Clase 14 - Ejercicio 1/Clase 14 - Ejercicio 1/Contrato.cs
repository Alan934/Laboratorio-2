using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_14___Ejercicio_1
{
    class Contrato : Impresora, IImprimible
    {
       public void Imprimir()
    {
        Console.WriteLine("Soy un contrato muy legal.");
    }
    }
}
