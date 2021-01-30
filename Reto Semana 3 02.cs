using System;

namespace Reto_Semana_3_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/djUD5CW20kU

            //Referencia del valor de cuota moderadora 2021
            //https://www.minsalud.gov.co/sites/rid/Lists/BibliotecaDigital/RIDE/VP/DOA/cuotas-moderadoras-copagos-2021.pdf


            int smmlv = 908526;

            Console.WriteLine("Ingrese su salario");
            int salario = int.Parse(Console.ReadLine());

            if (salario < smmlv * 2)
            {
                Console.WriteLine("A usted le corresponde la tarifa A");
                Console.WriteLine("Con un valor de cuota moderadora de: 3500$");
            }
            else if (salario < smmlv * 5)
            {
                Console.WriteLine("A usted le corresponde la tarifa B");
                Console.WriteLine("Con un valor de cuota moderadora de: 14000$");
            }
            else
            {
                Console.WriteLine("A usted le corresponde la tarifa C");
                Console.WriteLine("Con un valor de cuota moderadora de: 36800$");
            }
        }
    }
}
