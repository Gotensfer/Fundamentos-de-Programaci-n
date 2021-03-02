using System;

namespace Reto_Semana_06_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/MQcUhRfExjs
            
            Random random = new Random();
            int totalPuntos = 0, vidas = 3, turno = 1, dado = 0;
            string inputUsuario = "";

            Console.WriteLine("¡Bienvenido al juego!");

            while (true)
            {
                //Mostrar estadísticas
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("|| Estadísticas ||");
                Console.WriteLine("Vidas: " + vidas);
                Console.WriteLine("Puntos: " + totalPuntos );
                Console.WriteLine("Turno: " + turno + "\n\n");
                Console.ForegroundColor = ConsoleColor.White;

                //Preguntar por retirarse
                Console.WriteLine("¿Desea retirarse? (s/n)");
                inputUsuario = Console.ReadLine();
                while (inputUsuario != "s" && inputUsuario != "n")
                {
                    Console.WriteLine("Comando Desconocido");
                    inputUsuario = Console.ReadLine();
                }

                if (inputUsuario == "s") return;


                /// TIRADA DEL DADO
                //En cada 3 turnos tirar 2 dados
                if (turno % 3 == 0)
                {
                    int dado1 = random.Next(1, 7);
                    int dado2 = random.Next(1, 7);

                    Console.WriteLine("Has sacado un " + dado1 + " y un " + dado2 + "\n\n\n");

                    //Ganar una vida al sacar un par
                    if (dado1 == dado2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡Has ganado una vida al sacar un par!");
                        vidas++;
                    }
                }
                //Tirada Normal
                else
                {
                    dado = random.Next(1, 7);

                    Console.WriteLine("Has sacado " + dado + "\n\n\n");
                    totalPuntos += dado;
                }
                

                
                
                //Perder una vida cada 2 turnos
                if (turno % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Has perdido 1 vida al pasar 2 turnos");
                    vidas--;
                }
           
                
                //Perder en caso de quedarse sin vidas
                if (vidas == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Te has quedado sin vidas y has perdido!");
                    return;
                }


                //Ganar al alcanzar los 100 puntos
                if (totalPuntos >= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("¡Has ganado al alcanzar los 100 puntos!");
                    return;
                }

                Console.ForegroundColor = ConsoleColor.White;

                turno++;
            }
        }
    }
}
