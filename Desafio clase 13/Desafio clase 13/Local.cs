using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_clase_13
{
    class Local : Inmobiliaria
    {
        private int numeroVentanas;

        public Local(int numeroVentanas, double precioBase, double superficie, int añosAntiguedad)
            : base(precioBase, superficie, añosAntiguedad)
        {
            this.numeroVentanas = numeroVentanas;
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

        public double CalculoSuperficie()
        {
            double i;
            if (superficie > 50)
            {
                i = precioBase * 0.01;
            }
            else
            {
                i = 0;
            }
            return i;
        }

        public double CalculosFinalLocal()
        {
            double resultado;
            if (numeroVentanas <= 4 && numeroVentanas >=2)
            {
                return resultado = precioBase + CalculoSuperficie() - CalculoAños();
            }
            if (numeroVentanas > 4)
            {
                return resultado = precioBase + CalculoSuperficie() - CalculoAños() + (precioBase * 0.02);
            }
            else if (numeroVentanas <= 1)
            {
                return resultado = precioBase + CalculoSuperficie() - CalculoAños() - (precioBase * 0.02);
            }
            return resultado=0;
        }

        public double MostrarVentanas()
        {
            double resultado;
            if (numeroVentanas <= 4 && numeroVentanas >=2)
            {
                return resultado = 0;
            }
            if (numeroVentanas > 4)
            {
                return resultado = /*+*/ (precioBase * 0.02);
            }
            else if (numeroVentanas <= 1)
            {
                return resultado = /*-*/ (precioBase * 0.02);
            }
            return resultado = 0;
        }
    }
}
