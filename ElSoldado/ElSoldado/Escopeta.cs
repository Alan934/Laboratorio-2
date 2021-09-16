using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    class Escopeta : Arma
    {
        public Escopeta()
        {
            nombre = "Escopeta";
        }
            
        public override string Disparar()
        {
            return "¡Paaa!...";
        }
        
    }
}
