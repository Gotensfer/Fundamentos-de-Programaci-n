using System;

namespace Desafio_01___04___2
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/20B4ruiOmHs

            //Entradas

            Console.WriteLine("Ingrese el ángulo d");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el ángulo b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el lado y");
            double y = double.Parse(Console.ReadLine());


            //Proceso

                //Cálculo del ángulo a
            double a = 180 - 90 - b - d;

                //Conversion grad a rad de a
            double aRad = a * Math.PI / 180;

                //Cálculo del lado z
            double z = y / Math.Tan(aRad);

            //Salidas

            Console.WriteLine("El lado z es:");
            Console.WriteLine(z);

        }
    }
}
