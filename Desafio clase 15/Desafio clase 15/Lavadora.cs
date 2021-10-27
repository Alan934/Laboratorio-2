using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_clase_15
{
    class Lavadora : Electrodomestico
    {
        private int carga;

        public Lavadora() : base()
        {
            PrecioBase = 100;
            Color = "Blanco";
            Letra = "F";
            ConsumoEnergia = "F";
            Peso = 5;
            carga = 5;
        }

        public Lavadora(int carga)
        {
            this.carga = carga;
        }

        public int AumentoCarga()
        {
            if (carga > 30)
            {
                return 50;
            }
            else
            {
                return 0;
            } 
        }

        public double PrecioFinalLavadora()
        {
            return PrecioFinal() + AumentoCarga();
        }
    }
}
