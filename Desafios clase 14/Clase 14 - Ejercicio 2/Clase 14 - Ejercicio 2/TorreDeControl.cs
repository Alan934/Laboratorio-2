using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_14___Ejercicio_2
{
    class TorreDeControl
    {
        List<IVolador> voladores = new List<IVolador>();

        public void AgregarVolador(IVolador unVolable)
        {
            voladores.Add(unVolable);
        }

        public void VuelenTodos()
        {
            foreach (IVolador v in voladores)
            {
                v.Volador();
            }
        }

        public void Menu()
        {
            Console.WriteLine("\nMenu: " + 
                "\n1. Hacer volar Pato." + 
                "\n2. Hacer volar Boing 747." + 
                "\n3. volar a superman." +
                "\n4. Salir.");
        }
    }
}
