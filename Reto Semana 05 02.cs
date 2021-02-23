using System;

namespace Reto_Semana_05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/Iv2V5pehKqo
            
            double x = 0;
            Console.WriteLine("Ingrese el valor de x para e^x");

            x = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: " + Euler(x));
           

        }

        static double Euler(double x)
        {
            int n = 100;
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                total += Math.Pow(x, i) / Factorial(i);
            }
            return total;
        }

        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}
