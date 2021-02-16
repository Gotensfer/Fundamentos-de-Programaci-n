using System;

namespace Reto_Semana_04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "s";
            int total = 0;
            int i = 1;

            int edadMinima = 0;
            string nombreEdadMinima = "";

            int edadMaxima = 0;
            string nombreEdadMaxima = "";

            while (S == "s")
            {
                Console.Write("Ingrese el nombre de la persona: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la edad de " + nombre + ": ");
                int edad = int.Parse(Console.ReadLine());


                if (i == 1)
                {
                    edadMinima = edad;
                    nombreEdadMinima = nombre;

                    edadMaxima = edad;
                    nombreEdadMaxima = nombre;
                }

                if (edad < edadMinima)
                {
                    edadMinima = edad;
                    nombreEdadMinima = nombre;
                }

                if (edad > edadMaxima)
                {
                    edadMaxima = edad;
                    nombreEdadMaxima = nombre;
                }

                i++;
                total += edad;

                Console.WriteLine("¿Desea ingresar otra persona? ( s | n ) \n");
                S = Console.ReadLine();
            }

            Console.WriteLine("\nPromedio de las edades: " + (total / i));
            Console.WriteLine(nombreEdadMinima + " es quien tiene la menor edad con " + edadMinima + " años");
            Console.WriteLine(nombreEdadMaxima + " es quien tiene la mayor edad con " + edadMaxima + " años");
        }
    }
}
