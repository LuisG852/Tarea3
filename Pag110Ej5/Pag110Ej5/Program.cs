using System;

namespace Pag110Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double resultado, num2, longi, apotema;
            Console.WriteLine("Que desea hacer");
            Console.WriteLine("1 - calcular el perimetro");
            Console.WriteLine("2 - calcular el area de cualquier poligono regular");
            Console.Write("............       ");
            num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.Write("Introduzca el diametro: ");
                num2 = double.Parse(Console.ReadLine());
                resultado = (num2 * 3.14159);
                Console.WriteLine("El resultado es de: " + resultado);
            }
            else if (num == 2)
            {
                Console.Write("Introduzca la longitud: ");
                longi = double.Parse(Console.ReadLine());
                Console.Write("Introduzca la longitud: ");
                apotema = double.Parse(Console.ReadLine());
                resultado = (5 * longi * apotema);
                Console.WriteLine("El resultado es de: " + resultado);


            }
        }
    }
}
