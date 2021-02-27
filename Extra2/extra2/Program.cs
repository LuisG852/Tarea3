using System;

namespace extra2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, numero;
             long factorial = 1;
             Console.Write("Ingrese un número:");
             numero = int.Parse(Console.ReadLine());
             Console.WriteLine("\n" + numero + "! = 1");
             for (i = 2; i <= numero; i++)
            {
                factorial *= i;
                Console.WriteLine("\u00D7" + i);
            }
            Console.WriteLine("=" + factorial);
            Console.WriteLine("Presione cualquier tecla para terminar...");
            Console.ReadKey();
        }
    }
}
