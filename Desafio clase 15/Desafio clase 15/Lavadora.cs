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
