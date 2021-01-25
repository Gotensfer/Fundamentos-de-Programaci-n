using System;

public class Programa2
{
	public static void Main()
	{
		//https://youtu.be/4AjDMfblLRs

		//Entradas 

		Console.WriteLine("Ingrese la hipotenusa");
		double t = double.Parse(Console.ReadLine());

		Console.WriteLine("Ingrese su angulo conocido en grados");
		double a = double.Parse(Console.ReadLine());

		//Proceso

			//Nota, las operaciones con math utilizan Radianes, por tanto la conversion

		double aR = a * Math.PI / 180; //Angulo A en Radianes


		double y = Math.Sin(aR) * t;

		double z = Math.Cos(aR) * t;



		double c = 180 - 90 - a;

		//Salidas

		Console.WriteLine("Los lados del triangulo son:");
		Console.WriteLine(y.ToString() + "  " + z.ToString());

		Console.WriteLine("El angulo restante es:");
		Console.WriteLine(c);

	}
}
