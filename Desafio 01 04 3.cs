using System;

namespace Reto_01___04___3
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/OmxW-Z6zUT8

            //Entradas

            Console.WriteLine("Ingrese la hipotenusa w");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el ángulo d");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el lado x");
            double x = double.Parse(Console.ReadLine());


            //Proceso

            //Conversión Grad a Rad de d
            double dRad = d * Math.PI / 180;

            //Cálculo del lado y
            double y = Math.Cos(dRad) * w - x;


            //Salidas

            Console.WriteLine("El lado y es:");
            Console.WriteLine(y);
        }
    }
}
