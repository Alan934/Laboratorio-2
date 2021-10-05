using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_clase_13
{
    class Inmobiliaria
    {
        protected double precioBase;
        protected double superficie;
        protected int añosAntiguedad;

        public Inmobiliaria(double precioBase, double superficie, int añosAntiguedad)
        {
            this.precioBase = precioBase;
            this.superficie = superficie;
            this.añosAntiguedad = añosAntiguedad;
        }
    }
}
