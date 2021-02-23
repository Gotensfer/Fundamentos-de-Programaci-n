using System;

namespace Reto_Semana_05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            Console.WriteLine("Ingrese el valor de x para Sin(x)");

            x = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: " + Sin(x));
        }

        static double Sin(double x)
        {
            int n = 100;
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                total += ((Math.Pow(-1, i)) / Factorial((2 * i) + 1)) * (Math.Pow(x, (2 * i) + 1));
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
