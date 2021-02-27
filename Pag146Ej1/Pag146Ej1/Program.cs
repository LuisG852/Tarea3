using System;

namespace Pag146Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dato;

            Console.WriteLine("Ingresa el numero de la tabla que desees consultar:");
            dato = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(dato + "x" + i + "=" + (i * dato));
            }

            Console.ReadKey();
        }
    }
}
