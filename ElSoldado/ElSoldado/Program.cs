using System;

namespace ElSoldado
{
    class Program
    {
        static void Main(string[] args)
        {
            Rifle _rifle = new Rifle();
            Escopeta _escopeta = new Escopeta();
            Revolver _revolver = new Revolver();
            Soldado _soldado = new Soldado();

            Menu menu = new Menu(ref _soldado, ref _rifle, ref _escopeta, ref _revolver);
            
        }
    }
}
