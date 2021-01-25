using System;

public class Programa1
{
	public static void Main()
	{
		// Programa I
		//https://youtu.be/QdCoEuhkTng

		//Entradas

		Console.WriteLine("Ingrese el lado 1");
		double z = double.Parse(Console.ReadLine());

		Console.WriteLine("Ingrese el lado 2");
		double y = double.Parse(Console.ReadLine());

		//Proceso

			//Hipotenusa
		double t = Math.Sqrt((y*y)+(z*z));

			//Angulo c
		double c = Math.Asin(z / t);
		c = c * (180 / Math.PI);  //Otra forma es usando el operador *= 

			//Angulo a
		double a = 180 - c - 90;

		//Salidas

		Console.WriteLine("La Hipotenusa es:");
		Console.WriteLine(t);

		Console.WriteLine("Sus angulos son: ");
		Console.WriteLine(c.ToString() + "  " + a.ToString());
	}



}
