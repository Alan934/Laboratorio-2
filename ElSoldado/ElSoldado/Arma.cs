using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    abstract class Arma
    {
        protected string nombre="";

        public string Nombre 
        {
            get => nombre;
        }
        public abstract string Disparar();
    }
}
