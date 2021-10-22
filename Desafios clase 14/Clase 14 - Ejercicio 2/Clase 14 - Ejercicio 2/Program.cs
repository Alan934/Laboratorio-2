using System;

namespace Clase_14___Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl torre = new TorreDeControl();
            Boing747 boing = new Boing747();
            Pato pato = new Pato();
            Superman superman = new Superman();
            
            torre.AgregarVolador(pato);
            torre.AgregarVolador(boing);
            torre.AgregarVolador(superman);
            torre.VuelenTodos();

            Console.ReadKey();
        }
    }
}
