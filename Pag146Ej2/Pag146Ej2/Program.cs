using System;

namespace Pag146Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Base, Exponente;

            Console.WriteLine("Ingresa la base de la operacion: ");
            Base = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Ahora ingrese el exponente a elevarlo.");
            Exponente = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Base: {Base}, Exponente {Exponente}. -> {Base}^{Exponente}\nResultado: {Math.Pow(Base, Exponente)}");

            Console.ReadKey();
        }
    }
}
