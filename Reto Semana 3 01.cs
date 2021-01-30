using System;

namespace Reto_Semana_3_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/zrCKnvEaY5w

            //Valor del salario mínimo para el 2021
            int smmlv = 908526;

            Console.WriteLine("Ingrese su salario mínimo");
            int salario = int.Parse(Console.ReadLine());

            if (salario < smmlv * 2) //Menos de 2 salarios mínimos
            {
                Console.WriteLine("A usted le corresponde la tarifa A");
            }
            else if (salario < smmlv * 4) //Entre 2 y menos de 4 salarios mínimos
            {
                Console.WriteLine("A usted le corresponde la tarifa B");
            }
            else //4 o más salarios mínimos
            {
                Console.WriteLine("A usted le corresponde la tarifa C");
            }

        }
    }
}
