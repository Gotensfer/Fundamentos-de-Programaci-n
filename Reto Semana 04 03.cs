using System;

namespace Reto_Semana_04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/hlAwpFMUKEk
            
            Random random = new Random();
            int dadoAnterior = 0, dadoActual = 0, total = 0, turno = 0;

            string continuar = "s";

            while (continuar == "s")
            {
                dadoActual = random.Next(1, 13);

                ///Modo trampa
                /*
                dadoActual = int.Parse(Console.ReadLine());
                */

                Console.WriteLine("Sacaste un " + dadoActual);

                turno++;

                Console.WriteLine("Turno: " + turno);

                total += dadoActual;

                Console.WriteLine("Tu total hasta el momento es " + total);

                if (turno > 3)
                {
                    //Perder en caso de sacar un número impar
                    if (dadoActual % 2 != 0)
                    {
                        //Perder
                        Console.WriteLine("¡Has perdido al sacar un impar!");
                        continuar = "";
                    }


                }

                //Ganar en caso de sacar un 12 seguido de un 10
                if (dadoAnterior == 12 && dadoActual == 10)
                {

                    Console.WriteLine("¡Has Ganado al sacar un 12 y luego un 10!");
                    continuar = "";
                }

                //Ganar si se alcanza un total de 100 o más
                if (total >= 100)
                {
                    Console.WriteLine("¡Has Ganado al alcanzar un total de 100!");
                    continuar = "";
                }


                //Asignar la tirada de este dado para que sea tomado como tirada anterior en el siguiente ciclo
                dadoAnterior = dadoActual;


                if (continuar == "s")
                {
                    Console.WriteLine("¿Desea continuar? (s/n)");
                    continuar = Console.ReadLine();
                }

            }
        }
    }
}
