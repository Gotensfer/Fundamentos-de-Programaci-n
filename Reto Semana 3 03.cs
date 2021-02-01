using System;

namespace Reto_Semana_3_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://youtu.be/kKnyJKRCQI4

            Console.WriteLine("Ingrese su salario mensual");
            int salario = int.Parse(Console.ReadLine());
            double baseDeCotizacion = salario * 0.4;   //40% del salario
            if (baseDeCotizacion < 877802)
            {
                baseDeCotizacion = 877802;  
                //Valores con base al año 2020 (w t f Gio)
            }

            
            Console.WriteLine("Ingrese su tipo de contrato digitando el numero correspondiente");
            Console.WriteLine("1 para Dependiente");
            Console.WriteLine("2 para Independiente");
            int Tcontrato = int.Parse(Console.ReadLine());

            if (Tcontrato == 1)
            {
                double deduccionPension = baseDeCotizacion * 0.04;   //4% de la base de cotización
                double deduccionEPS = baseDeCotizacion * 0.04;       //4% de la base de cotización
                //La deducción por ARL la cubre la empresa en su totalidad

                double deducciones = deduccionPension + deduccionEPS;

                double salarioRealMensual = salario - deducciones;

                double salarioAnual = (salarioRealMensual * 12) + salario;

                Console.WriteLine("Su salario mensual real es: $" + salarioRealMensual);
                Console.WriteLine("Su salario anual con deducciones y bonificación es: $" + salarioAnual);
            }
            else
            {
                Console.WriteLine("Ingrese su número de clase de riesgo (1 - 5)");
                int claseDeRiesgo = int.Parse(Console.ReadLine());

                double deduccionPension = baseDeCotizacion * 0.16;   //16%   de la base de cotización
                double deduccionEPS = baseDeCotizacion * 0.125;      //12.5% de la base de cotización
                double deduccionARL;

                if (claseDeRiesgo == 1)
                {
                    deduccionARL = baseDeCotizacion * 0.00522;   //0.522% de la base de cotización
                }
                else if (claseDeRiesgo == 2)
                {
                    deduccionARL = baseDeCotizacion * 0.01044;   //1.044% de la base de cotización
                }
                else if (claseDeRiesgo == 3)
                {
                    deduccionARL = baseDeCotizacion * 0.02436;   //2.436% de la base de cotización
                }
                else if (claseDeRiesgo == 4)
                {
                    deduccionARL = baseDeCotizacion * 0.04350;   //4.350% de la base de cotización
                }
                else
                {
                    deduccionARL = baseDeCotizacion * 0.06960;   //6.960% de la base de cotización
                }
                
                double deducciones = deduccionPension + deduccionEPS + deduccionARL;

                double salarioRealMensual = salario - deducciones;                

                double salarioAnual = salarioRealMensual * 12;

                Console.WriteLine("Su salario mensual real es: $" + salarioRealMensual);
                Console.WriteLine("Su salario anual con deducciones: $" + salarioAnual);
            }
 
        }
    }
}
