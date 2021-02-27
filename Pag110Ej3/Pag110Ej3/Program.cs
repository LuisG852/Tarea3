using System;

namespace Pag110Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2;
            float resultado;
            Console.WriteLine("1 - Medicamentos");
            Console.WriteLine("2 - otros");
            Console.Write("............    ");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    {
                        Console.Write("Ingrese la cantidad del producto:");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("El impuesto aplicado es de 0% y el total es de: " + num2);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Ingrese la cantidad del producto:");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = (float)(num2 * 0.05);
                        Console.WriteLine("El impuesto aplicado es de 15% y el total es de: " + resultado);
                        break;
                    }
            }
    }

    }
}
