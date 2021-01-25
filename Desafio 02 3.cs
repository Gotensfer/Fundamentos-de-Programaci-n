using System;
public class Programa2
{
	public static void Main()
	{
		//https://youtu.be/OLO090_fp_A

		//Entradas 
		Console.WriteLine("Ingrese su angulo en grados:");
		double c = double.Parse(Console.ReadLine());

		Console.WriteLine("Ingrese su lado opuesto a su angulo");
		double z = double.Parse(Console.ReadLine());

		//Proceso


			//Nota, las operaciones con math utilizan Radianes, por tanto la conversion

		double cR = c * Math.PI / 180; //Angulo C en Radianes

		double t = z / Math.Sin(cR);

		double y = Math.Cos(cR) * t;

		double a = 180 - 90 - c;


		//Salidas

		Console.WriteLine("Su lado restante es:");
		Console.WriteLine(y);

		Console.WriteLine("Su hipotenusa es:");
		Console.WriteLine(t);

		Console.WriteLine("Su angulo restante es:");
		Console.WriteLine(a);
	}
}
