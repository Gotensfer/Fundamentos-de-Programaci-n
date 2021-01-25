using System;

namespace Programa_IV__Reto_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/34qwJ02hgKI

            //Entradas 

            Console.WriteLine("Ingrese el ángulo b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el lado z");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el lado y");
            double y = double.Parse(Console.ReadLine());           


            //Proceso

                //Conversión grad a rad de b
            double bRad = b * Math.PI / 180;
                
                //Cálculo del ángulo a
            double a = Math.Atan(y / z);

                //Cálculo del lado x
            double x = Math.Tan(bRad + a) * z - y;


            //Salidas

            Console.WriteLine("El lado x es:");
            Console.WriteLine(x);
        }
    }
}
