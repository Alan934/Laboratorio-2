using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    class Rifle : Arma
    {
        public Rifle()
        {
            nombre = "Rifle";
        }

        public override string Disparar()
        {
            return "Pum pum pum!...";
        }
    }
}
