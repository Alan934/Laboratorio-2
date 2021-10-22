using System;

namespace Clase_14___Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato contrato = new Contrato();
            Foto foto = new Foto();
            Documento doc = new Documento();
            Impresora impresora = new Impresora();

            impresora.AgregarImprimible(doc);
            impresora.AgregarImprimible(foto);
            impresora.AgregarImprimible(contrato);

            impresora.ImprimirTodo();

            Console.ReadKey();
        }
    }
}
