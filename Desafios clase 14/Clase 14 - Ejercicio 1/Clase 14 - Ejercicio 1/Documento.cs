using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_14___Ejercicio_1
{
    class Documento : Impresora, IImprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un documento de word.");
        }
    }
}
