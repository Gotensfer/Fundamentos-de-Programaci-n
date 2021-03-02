using System;

namespace Reto_Semana_06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/hwy6EEoI7ZU
            
            Random random = new Random();
            int totalPuntos = 0, vidas = 3, contador1s = 0, contador6s = 0, dadosEspecialesRestantes = 2, dado = 0;
            string inputUsuario = "";

            Console.WriteLine("¡Bienvenido al juego!");

            while (true)
            {
                //Mostrar estadísticas
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("|| Estadísticas ||");
                Console.WriteLine("Vidas: " + vidas);
                Console.WriteLine("Puntos: " + totalPuntos);
                Console.WriteLine("Dados especiales restantes: " + dadosEspecialesRestantes + "\n");
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
                //Solo preguntar por usar el dado si aun tiene dados especiales restantes
                if (dadosEspecialesRestantes != 0)
                {
                    Console.WriteLine("¿Desea usar un dado de doce caras? De lo contrario se usara el dado normal");
                    inputUsuario = Console.ReadLine();
                    while (inputUsuario != "s" && inputUsuario != "n")
                    {
                        Console.WriteLine("Comando Desconocido");
                        inputUsuario = Console.ReadLine();
                    }

                    //Tirada del dado especial
                    if (inputUsuario == "s")
                    {
                        dado = random.Next(1, 13);
                        dadosEspecialesRestantes--;

                    }

                    //Tirada del dado normal
                    if (inputUsuario == "n")
                    {
                        dado = random.Next(1, 7);
                    }
                }
                else //En caso de no tener dados especiales
                {
                    //Tirada del dado normal
                    dado = random.Next(1, 7);
                }

                Console.WriteLine("Has sacado " + dado + "\n\n\n");
                totalPuntos += dado;


                ///Contador 1s
                if (dado == 1) contador1s++; //Aumento del contador

                if (contador1s == 2) //Verificacion de si el contador llego a 2
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Has perdido una vida al sacar 2 veces un 1!");

                    vidas--;
                    totalPuntos -= 10;
                    contador1s = 0; //Restablecimiento del contador
                }

                ///Contador 6s
                if (dado == 6) contador6s++; //Aumento del contador
                else contador6s = 0; //Restablecimiento del contador si no son consecutivos

                if (contador6s == 2) //Verificacion de si el contador llego a 2
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Has sacado dos 6s consecutivos!");
                    

                    if (vidas < 3) //Solo ganar una vida en caso de tener menos de 3
                    {
                        Console.WriteLine("Has ganado una vida extra");
                        vidas++;
                    }
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("No pudiste ganar una vida extra al ya estar al máximo de 3 vidas");
                    }

                    contador6s = 0;
                    
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


            }
        }
    }
}
