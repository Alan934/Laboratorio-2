using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_clase_15
{
    class Electrodomestico
    {
        private double precioBase;
        private string color;//disponibles blanco, negro, rojo, azul y gris.
        private string consumoEnergia; // A, B, C, D, E, F.
        private double peso; // kg


        public double PrecioBase { get => precioBase; set => precioBase = value; }
        public string Color { get => color; set => color = value; }
        public string ConsumoEnergia { get => consumoEnergia; set => consumoEnergia = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Letra { get => consumoEnergia; set => consumoEnergia = value; }

        public Electrodomestico()
        {
            PrecioBase = 100;
            Color = "Blanco";
            Letra = "F";
            Peso = 5;
        }

        public Electrodomestico(double precioBase, double peso)
        {
            this.PrecioBase = precioBase;
            this.Peso = peso;
        }

        public Electrodomestico(double precioBase, string color, string consumoEnergia, double peso)
        {
            this.PrecioBase = precioBase;
            this.Color = color;
            this.ConsumoEnergia = consumoEnergia;
            this.Peso = peso;
        }

        //contains devulve true o false si es que existe el elemento
        public int ComprobarConsumoEnergetico(string letra)
        {
            if (letra == "A")
            {
                return 100;
            }
            if (letra == "B")
            {
                return 80;
            }
            if (letra == "C")
            {
                return 60;
            }
            if (letra == "D")
            {
                return 50;
            }
            if (letra == "E")
            {
                return 30;
            }
            if (letra == "F")
            {
                return 10;
            }
            return 10;//valor por defecto
        }

        public string ComprobarColor(string color)
        {
            string color1 = "Blanco";
            if (color == null)
            { 
                return color1;
            }
            else
            {
                return color;
            }
        }

        public int ComprobarPeso()
        {
            if (Peso >= 0 && Peso <= 19)
            {
                return 10;
            }
            if (Peso >= 20 && Peso <= 49)
            {
                return 50;
            }
            if (Peso >= 50 && Peso <= 79)
            {
                return 80;
            }
            if (Peso >= 80)
            {
                return 100;
            }
            return 10;//valor por defecto
        }

        public double PrecioFinal()
        {
            return PrecioBase + ComprobarConsumoEnergetico(Letra) + ComprobarPeso();
        }
    }
}
