using System;

namespace Reto_01___04___4
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/5P_mDlTptdc

            //Entradas

            Console.WriteLine("Ingrese su hipotenusa w");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su hipotenusa t");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su ángulo c");
            double c = double.Parse(Console.ReadLine());


            //Proceso

                //Conversión de Grad a Rad de c
            double cRad = c * Math.PI / 180;

                //Cálculo de los lados z & y
            double z = Math.Sin(cRad) * t;
            double y = Math.Cos(cRad) * t;

                //Cálculo del ángulo d    
            double d = Math.Asin(z / w);

                //Cálculo del lado x
            double x = Math.Cos(d) * w - y;

            //Salidas
            Console.WriteLine("El lado x es:");
            Console.WriteLine(x);



        }
    }
}
