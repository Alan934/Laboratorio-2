using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    class Soldado
    {
        private Arma _arma;
        public void RecogerArma(Arma arma)
        {
            if (this._arma != null)
            {
                Console.WriteLine("El soldado no puede usar 2 armas a la vez, por favor tire el arma y agarre otra.");
            }
            else
            {
                _arma = arma;
                Console.WriteLine("!Recogio el arma¡");
            }
        }

        public void DejarArma()
        {
            if (this._arma != null)
            {
                _arma = null;
                Console.WriteLine("Dejo el arma");
            }
            else
            {
                Console.WriteLine("El soldado no tiene armas en sus manos");
            }
        }

        public void JalarGatillo()
        {
            if (this._arma != null)
            {
                string sonidoDisparo = _arma.Disparar();
                Console.WriteLine(sonidoDisparo);
            }
            else
            {
                Console.WriteLine("No tiene un arma, agarre una que se muere");
            }
        }

        public void VerArma()
        {
            if (this._arma != null)
            {
                Console.WriteLine(_arma.Nombre);
            }
            else
            {
                Console.WriteLine("No tiene un arma en sus manos");
            }
        }
    }
}
