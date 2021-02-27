using System;

namespace Pag110Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado, num, num2;
            Console.WriteLine("1 - De grados a radianes");
            Console.WriteLine("2 - De radianes a grados");
            Console.Write("............    ");
            num = float.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    {

                        Console.Write("Ingresa la cantidad a convertir: ");
                        num2 = float.Parse(Console.ReadLine());
                        resultado = num2 * 3.1416 / 180;
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    }
                case 2:
                    {

                        Console.Write("Ingresa la cantidad a convertir: ");
                        num2 = float.Parse(Console.ReadLine());
                        resultado = num2 * 180 / 3.1416;
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    }
            }
    }
}
}

