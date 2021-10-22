using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_14___Ejercicio_1
{
    class Impresora
    {
        List<IImprimible> ColaDeImpresion = new List<IImprimible>();

        public void AgregarImprimible(IImprimible unImprimible)
        {
            ColaDeImpresion.Add(unImprimible);
        }

        public void ImprimirTodo()
        {
            foreach(IImprimible i in ColaDeImpresion)
            {
                i.Imprimir();
            }
        }

    }
}
