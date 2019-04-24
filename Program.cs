using System;
using System.Collections.Generic;

namespace DiccionarioGenerico
{
    class Program
    {

        static void Main(string[] args)
        {
            Provincia provincia = new Provincia();

            Console.WriteLine("Lista de provincias");
            
            Console.Write("Ingrese el número de la provincia a buscar : ");
            var BuscarProvincia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La Provincia y su capital es : {0} ", provincia.Buscar(BuscarProvincia));

            Console.ReadKey();
        }
    }

    
}
