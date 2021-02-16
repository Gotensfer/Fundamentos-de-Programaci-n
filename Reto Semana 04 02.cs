using System;

namespace Reto_Semana_04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int dado1 = 0, dado2 = 2, total = 0, contadorParesConsecutivos = 0;
            double turnos = 0, turnosQueSacoMasDe6 = 0;
            string continuar = "s";
            string respuestaReglaOpcional = "";

            Console.WriteLine("REGLA DE 3 CONSECUTIVOS\nSi usted llega a sacar 3 pares de forma consecutiva ganará\n¿Desea jugar con esta nueva regla? (s/n)");
            respuestaReglaOpcional = Console.ReadLine();

            while (continuar == "s")
            {
                turnos++;

                Console.WriteLine("Turno: " + turnos);

                
                dado1 = random.Next(1, 7);
                dado2 = random.Next(1, 7);
                

                ///Modo trampa
                /*
                dado1 = int.Parse(Console.ReadLine());
                dado2 = int.Parse(Console.ReadLine());
                */

                Console.WriteLine("Tu primer dado saco un " + dado1);
                Console.WriteLine("Tu segundo dado saco un " + dado2);




                total += dado1 + dado2;

                Console.WriteLine("Tu total es de " + total);


                //Verificador de que la Regla de 3 pares consecutivos está activada
                if (respuestaReglaOpcional == "s")
                {
                    if (dado1 == dado2) //Ambos dados pares
                    {
                        contadorParesConsecutivos++;

                        if (contadorParesConsecutivos == 3)
                        {
                            Console.WriteLine("¡Has ganado al sacar 3 pares consecutivos!");
                            continuar = "";
                        }
                    }
                    else //Restablecer el contador
                    {
                        contadorParesConsecutivos = 0;
                    }
                }

                //Contador de turnos en los que sacó más de 6
                if (dado1 + dado2 > 6)
                {
                    turnosQueSacoMasDe6++;
                }

                //Verificador de que sacó un par de 1's
                if (dado1 == 1 && dado2 == 1)
                {
                    Console.WriteLine("¡Has perdido al sacar un par de 1's!");
                    continuar = "";
                }

                //Ganar si el total alcanza 100
                if (total >= 100)
                {
                    Console.WriteLine("¡Has ganado al alcanzar 100!");
                    continuar = "";
                }

                if (continuar == "s")
                {
                    Console.WriteLine("¿Desea continuar? (s/n)");
                    continuar = Console.ReadLine();
                    Console.WriteLine("");

                }
                
                if (continuar != "s") //Caso de partida finalizada
                {
                    Console.WriteLine("El % de turnos en los que al menos sacaste un 6 es del " + (turnosQueSacoMasDe6 / turnos) * 100 + "%");
                }
            }

           
        }
    }
}
