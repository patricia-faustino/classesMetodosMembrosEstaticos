using System;
using System.Globalization;

namespace areaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double aX = x.Area();

            double aY = y.Area();




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
