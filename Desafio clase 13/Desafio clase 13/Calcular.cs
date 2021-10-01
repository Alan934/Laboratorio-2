using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_clase_13
{
    class Calcular
    {
        private int numeroPiso;
        private int numeroVentanas;
        private double precioBase;
        private double superficie;
        private int añosAntiguedad;

        public Calcular(int numeroPiso, int numeroVentanas, double precioBase, double superficie, int añosAntiguedad)
        {
            this.numeroPiso = numeroPiso;
            this.numeroVentanas = numeroVentanas;
            this.precioBase = precioBase;
            this.superficie = superficie;
            this.añosAntiguedad = añosAntiguedad;
        }
        /*public int NumeroPiso { get => numeroPiso; set => numeroPiso = value; }
        public int NumeroVentanas { get => numeroVentanas; set => numeroVentanas = value; }
        public double PrecioBase { get => precioBase; set => precioBase = value; }
        public double Superficie { get => superficie; set => superficie = value; }
        public int AñosAntiguedad { get => añosAntiguedad; set => añosAntiguedad = value; }*/

        public double CalculosPiso()
        {
            double descuento;
            double precioTotal;
            double precioPiso;
            if (añosAntiguedad <= 15)
            {
                descuento = precioBase * 0.01;
            }
            else
            {
                descuento = precioBase * 0.02;
            }
            if (numeroPiso >= 3)
            {
                precioPiso = precioBase * 0.03;
            }
            else
            {
                precioPiso = 0;
            }

            return precioTotal = precioBase + precioPiso - descuento;
        }

        public double CalculosLocal()
        {
            double precioTotal;
            double descuento;
            double incremento;

            if (añosAntiguedad <= 15)
            { 
                descuento = precioBase * 0.01;
            }
            else
            {
                descuento = precioBase * 0.02;
            }

            if (superficie > 50)
            {
                incremento = precioBase * 0.01;
            }
            else
            {
                incremento = 0;
            }

            return precioTotal = precioBase + incremento - descuento;
        }

        public double CalculosFinalLocal()
        {
            double CalculosVentanas;
            if (numeroVentanas <= 1 || numeroVentanas >= 0)
            {
                return CalculosVentanas = CalculosLocal() + (precioBase * 0.02);
            }
            if (numeroVentanas <= 4 || numeroVentanas >= 2)
            {
                return CalculosVentanas = CalculosLocal() + 0;
            }
            else
            {
                return CalculosVentanas = CalculosLocal() - (precioBase * 0.02); 
            }
        }


    }
}
