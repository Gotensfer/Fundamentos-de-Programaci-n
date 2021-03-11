using System;

namespace Reto_Semana_08_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string fraseUsuario = "";
            string palabraUsario = "";

            Console.WriteLine("Ingresa la frase que desees");
            fraseUsuario = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingresa la palabra que deseas buscar y encontrar la cantidad de veces que aparece en tu frase");
            palabraUsario = Console.ReadLine().ToUpper();

            //Separar las palabras de la frase
            string[] palabras = fraseUsuario.Split(" ");

            //Iterar en cada palabra y revisar si esta es la misma que la que ingreso el usuario
            int contador = 0;
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i] == palabraUsario)
                {
                    Console.WriteLine("Encontrada la palabra en la posición " + i);
                    contador++;
                }
            }
            Console.WriteLine("La palabra apareció un total de " + contador + " veces");          
        }


    }
}
