using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_clase_13
{
    class Piso : Inmobiliaria
    {
        private int numeroPiso;

        public Piso(int numeroPiso, double precioBase, double superficie, int añosAntiguedad)
            : base(precioBase, superficie, añosAntiguedad)
        {
            this.numeroPiso = numeroPiso;
        }

        public double CalculoAños()
        {
            double descuento;
            if (añosAntiguedad <= 15)
            {
                descuento = precioBase * 0.01;
            }
            else
            {
                descuento = precioBase * 0.02;
            }
            return descuento;
        }

        public double CalculoPiso()
        {
            double i;
            if (numeroPiso >= 3)
            {
                i = precioBase * 0.03;
            }
            else
            {
                i = 0;
            }
            return i;
        }

        public double CalculoFinalPiso()
        {
            double resultado;
            return resultado = precioBase - CalculoAños() + CalculoPiso();
        }

    }
}
