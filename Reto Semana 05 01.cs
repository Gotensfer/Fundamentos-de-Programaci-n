using System;

namespace Reto_Semana_04_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asumiendo un blackjack jugado en individual y no simultáneo
            //https://youtu.be/bAhHsrOAdZA
            Console.ForegroundColor = ConsoleColor.Cyan;

            Random random = new Random();

            int jugadores, jugador = 0, carta, totalNumerico = 0, totalGanador = 0;
            double a;
            string respuestaJugador = "", jugadorGanador = "";

            Console.WriteLine("Ingrese la cantidad de jugadores");
            jugadores = int.Parse(Console.ReadLine());

            //Validación del número de jugadores
            while (jugadores < 2 || jugadores > 5)
            {
                Console.WriteLine("Solo se permite jugar entre 2 y 5 jugadores\n");
                Console.WriteLine("Ingrese la cantidad de jugadores");
                jugadores = int.Parse(Console.ReadLine());
            }

            
            while (jugador < jugadores) //Verificación para que el no jueguen más jugadores del establecido anteriormente
            {
                //Reseteo de valores 
                totalNumerico = 0;

                //Cambio de jugador que se verá reflejado en la siguiente iteración
                jugador++;

                Console.WriteLine("!Bienvenido a Blackjack jugador " + jugador + "!");

                carta = random.Next(1, 11);
                totalNumerico += carta;
                Console.Write("Tus cartas iniciales son un " + carta);

                carta = random.Next(1, 11);
                totalNumerico += carta;
                Console.Write(" y " + carta);

                Console.WriteLine("\nTu total inicial es de " + totalNumerico);

                Console.WriteLine("\n¿Desea arrastrar una carta? ( s / n )");
           
                respuestaJugador = Console.ReadLine();

                //Validación para el input del usuario
                while (respuestaJugador != "s" && respuestaJugador != "n")
                {
                    Console.WriteLine("Ingrese una respuesta correcta ( s / n )");
                    respuestaJugador = Console.ReadLine();
                }

                if (respuestaJugador != "s") //Retirarse de forma temprana
                {
                    Console.WriteLine("Te ha faltado un " + (21 - totalNumerico));

                    Console.WriteLine("");


                    //Establecer valores del Total ganador y el jugador Ganador
                    if (jugador == 1 && totalNumerico <= 21) //Solo aplicable al primer jugador para establecer los valores iniciales
                    {
                        totalGanador = totalNumerico;
                        jugadorGanador = jugador.ToString();
                    }
                    else if (totalNumerico > totalGanador && totalNumerico <= 21)
                    {
                        totalGanador = totalNumerico;
                        jugadorGanador = jugador.ToString();
                    }

                }

                while (respuestaJugador == "s") //Continuación del juego del jugador actual
                {
                    carta = random.Next(1, 11);
                    totalNumerico += carta;
                    Console.WriteLine("Has sacado una carta de " + carta);
                    Console.WriteLine("Tu total es de " + totalNumerico);

                    if (totalNumerico < 21) 
                    {
                        Console.WriteLine("\n¿Desea arrastrar una carta? ( s / n )");
                        respuestaJugador = Console.ReadLine();

                        //Validación para el input del usuario
                        while (respuestaJugador != "s" && respuestaJugador != "n")
                        {
                            Console.WriteLine("Ingrese una respuesta correcta ( s / n )");
                            respuestaJugador = Console.ReadLine();
                        }

                        if (respuestaJugador != "s") //No querer continuar
                        {
                            Console.WriteLine("Te ha faltado un " + (21 - totalNumerico) + " para ganar");

                            //Establecer valores del Total ganador y el jugador Ganador
                            if (jugador == 1 && totalNumerico <= 21) //Solo aplicable al primer jugador para establecer los valores iniciales
                            {
                                totalGanador = totalNumerico;
                                jugadorGanador = jugador.ToString();
                            }
                            else if (totalNumerico > totalGanador && totalNumerico <= 21)
                            {
                                totalGanador = totalNumerico;
                                jugadorGanador = jugador.ToString();
                            }



                        }
                    }
                    else if (totalNumerico == 21) //Ganar al ser quien alcanzo el 21
                    {
                        Console.WriteLine("!Has ganado!");
                        respuestaJugador = "";

                        //Establecer valores del Total ganador y el jugador Ganador
                        if (jugador == 1 && totalNumerico <= 21) //Solo aplicable al primer jugador para establecer los valores iniciales
                        {
                            totalGanador = totalNumerico;
                            jugadorGanador = jugador.ToString();
                        }
                        else if (totalNumerico > totalGanador && totalNumerico <= 21)
                        {
                            totalGanador = totalNumerico;
                            jugadorGanador = jugador.ToString();
                        }
                    }
                    else //Perder al pasarse de 21
                    {
                        Console.WriteLine("¡Has perdido al pasarte de 21!");
                        respuestaJugador = "";

                        //Establecer valores del Total ganador y el jugador Ganador
                        if (jugador == 1 && totalNumerico <= 21) //Solo aplicable al primer jugador para establecer los valores iniciales
                        {
                            totalGanador = totalNumerico;
                            jugadorGanador = jugador.ToString();
                        }
                        else if (totalNumerico > totalGanador && totalNumerico <= 21)
                        {
                            totalGanador = totalNumerico;
                            jugadorGanador = jugador.ToString();
                        }
                    }


                }
            }

            

            if (totalGanador == 0 && jugadorGanador == "") //Caso ningun ganador
            {
                Console.WriteLine("");
                Console.WriteLine("Nadie ha ganado");
            }
            else
            {
                //Caso ganador

                Console.WriteLine("");
                Console.WriteLine("El jugador " + jugadorGanador + " gana con un total de " + totalGanador);
            }

            

        }
    }
}
