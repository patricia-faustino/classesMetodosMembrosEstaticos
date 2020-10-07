using System;
using System.Globalization;

namespace areaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X:");
            double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double x3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pX = (x1 + x2 + x3) / 2;
            double aX = Math.Sqrt(pX * (pX- x1) * (pX - x2) * (pX - x3));

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            double y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pY = (y1 + y2 + y3) / 2;
            double aY = Math.Sqrt(pY * (pY - y1) * (pY - y2) * (pY - y3));

            Console.WriteLine("Área de X: " + aX.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + aY.ToString("F3",CultureInfo.InvariantCulture));

            if (aX > aY)
            {
                Console.WriteLine("Maior área : X");
            } else if (aY > aX)
            {
                Console.WriteLine("Maior área : Y");
            }
            else
            {
                Console.WriteLine("As áreas são iguais");
            }






        }
    }
}
