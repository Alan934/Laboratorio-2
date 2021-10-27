using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_clase_15
{
    class Television : Electrodomestico
    {
        private int resolucion;
        private bool sintonizadorTDT;

        public Television() : base()
        { 
            PrecioBase = 100;
            Color = "Blanco";
            Letra = "F";
            ConsumoEnergia = "F";
            Peso = 5;
            resolucion = 20;
            sintonizadorTDT = false;
        }

        public Television(int resolucion, bool sintonizadorTDT)
        {   
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }

        public double PrecioFinalTele()
        {
            if (resolucion > 40 && sintonizadorTDT == true)
            {
                return (PrecioFinal() + (PrecioFinal() * 0.3) + (PrecioFinal() * 0.5));
            }
            if (sintonizadorTDT == true)
            {
                return PrecioFinal() + (PrecioFinal() * 0.5);
            }
            if (resolucion > 40)
            {
                return PrecioFinal() + (PrecioFinal() * 0.3);
            }
            return PrecioFinal();
        }
    }
}
