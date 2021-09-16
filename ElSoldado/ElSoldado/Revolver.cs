using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    class Revolver : Arma
    {
        public Revolver()
        {
            nombre = "Revolver";
        }

        public override string Disparar()
        {
            return "Pum...";
        }
    }
}
