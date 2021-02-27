using System;

namespace Pag110Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("Digite un numero para saber si es numero primo o impar: ");
            num1 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("El numero ingresado es par");
            }
            else
            {
                Console.WriteLine("El numero ingresado es impar");
            }

        }
    }
}
